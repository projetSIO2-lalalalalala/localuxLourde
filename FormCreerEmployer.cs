using BCrypt.Net;
using localux.Models;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Utils;
using OtpNet;
using QRCoder;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace localux
{
    public partial class FormCreerEmployer : Form
    {
        private readonly MonDbContext cnx = new();

        public FormCreerEmployer()
        {
            InitializeComponent();
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            var nom = tbNom.Text.Trim();
            var prenom = tbPrenom.Text.Trim();
            var login = tbLogin.Text.Trim();
            var mdp = tbMdp.Text;

            if (string.IsNullOrWhiteSpace(nom) ||
                string.IsNullOrWhiteSpace(prenom) ||
                string.IsNullOrWhiteSpace(login) ||
                string.IsNullOrWhiteSpace(mdp))
            {
                MessageBox.Show("Tous les champs sont obligatoires.");
                return;
            }

            if (cnx.Employe.Any(emp => emp.Login == login))
            {
                MessageBox.Show("Ce login existe déjà.");
                return;
            }

            var hash = BCrypt.Net.BCrypt.HashPassword(mdp);
            var key = KeyGeneration.GenerateRandomKey(20);
            var otpCode = Base32Encoding.ToString(key);

            var employe = new Employe
            {
                Nom = nom,
                Prenom = prenom,
                Login = login,
                Mdp = hash,
                otpCode = otpCode,
                DateModificationMdp = DateTime.Now
            };

            cnx.Employe.Add(employe);
            cnx.SaveChanges();

            var historique = new HistoriqueMdp
            {
                Mdp = hash,
                DateModification = DateTime.Now,
                LeEmployeId = employe.Id
            };
            cnx.HistoriqueMdp.Add(historique);
            cnx.SaveChanges();

            try
            {
                EnvoyerQrCodeParMail(employe);
                MessageBox.Show("Employé créé et email envoyé avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Employé créé, mais l'email n'a pas pu être envoyé : {ex.Message}");
            }

            Close();
        }

        private static string ConstruireOtpUri(Employe employe)
        {
            return new OtpUri(
                OtpType.Totp,
                employe.otpCode,
                employe.Login,
                "SAVARY",
                OtpHashMode.Sha512,
                8,
                300).ToString();
        }

        private static void EnvoyerQrCodeParMail(Employe employe)
        {
            var uriString = ConstruireOtpUri(employe);

            using var qrGenerator = new QRCodeGenerator();
            using var qrCodeData = qrGenerator.CreateQrCode(uriString, QRCodeGenerator.ECCLevel.Q);
            using var qrCode = new QRCode(qrCodeData);
            using var qrCodeImage = qrCode.GetGraphic(2);
            using var memoryStream = new MemoryStream();

            qrCodeImage.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            memoryStream.Seek(0, SeekOrigin.Begin);

            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("testOTP@sio-savary.fr"));
            email.To.Add(MailboxAddress.Parse("l.olivier85150@gmail.com")); // conservé volontairement
            email.Subject = "Votre QRCode de connexion";

            var builder = new BodyBuilder();
            var image = builder.LinkedResources.Add("qrcode.jpg", memoryStream);
            image.ContentId = MimeUtils.GenerateMessageId();
            builder.HtmlBody = $"Bonjour {employe.Prenom},<br><br>Voici votre QRCode de connexion :<br><img src='cid:{image.ContentId}'>";
            email.Body = builder.ToMessageBody();

            using var smtpClient = new SmtpClient();
            smtpClient.Connect("ssl0.ovh.net", 465, SecureSocketOptions.SslOnConnect);
            smtpClient.Authenticate("admin@sio-savary.fr", "P@ssw0rd85!"); // conservé volontairement
            smtpClient.Send(email);
            smtpClient.Disconnect(true);
        }

        private void FormCreerEmployer_Load(object sender, EventArgs e)
        {
        }
    }
}
