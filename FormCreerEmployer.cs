using BCrypt.Net;
using localux.Models;
using OtpNet;
using System;
using System.Linq;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Utils;
using QRCoder;

namespace localux
{
    public partial class FormCreerEmployer : Form
    {
        private MonDbContext cnx = new MonDbContext();

        public FormCreerEmployer()
        {
            InitializeComponent();
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            string nom = tbNom.Text.Trim();
            string prenom = tbPrenom.Text.Trim();
            string login = tbLogin.Text.Trim();
            string mdp = tbMdp.Text;

            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) ||
                string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(mdp))
            {
                MessageBox.Show("Tous les champs sont obligatoires.");
                return;
            }

            if (cnx.Employe.Any(emp => emp.Login == login))
            {
                MessageBox.Show("Ce login existe déjà.");
                return;
            }

            string hash = BCrypt.Net.BCrypt.HashPassword(mdp);

            var employe = new Employe
            {
                Nom = nom,
                Prenom = prenom,
                Login = login,
                Mdp = hash,
                DateModificationMdp = DateTime.Now
                // Pas de champ Email
            };

            var key = KeyGeneration.GenerateRandomKey(20);
            employe.otpCode = Base32Encoding.ToString(key);

            // Utilisation du login comme identifiant dans l'URI OTP
            string uriString = new OtpUri(OtpType.Totp, employe.otpCode, employe.Login,
                                          "SAVARY", OtpHashMode.Sha512, 8, 300).ToString();

            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(uriString, QRCodeGenerator.ECCLevel.Q))
            using (QRCode qrCode = new QRCode(qrCodeData))
            using (Bitmap qrCodeImage = qrCode.GetGraphic(2))
            using (MemoryStream memoryStream = new MemoryStream())
            {
                qrCodeImage.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                memoryStream.Seek(0, SeekOrigin.Begin);

                // Préparation de l'email
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse("testOTP@sio-savary.fr"));
                email.To.Add(MailboxAddress.Parse("l.olivier85150@gmail.com")); // Email personnel
                email.Subject = "Votre QRCode de connexion";

                var builder = new BodyBuilder();
                var image = builder.LinkedResources.Add("qrcode.jpg", memoryStream);
                image.ContentId = MimeUtils.GenerateMessageId();
                builder.HtmlBody = $"Bonjour {employe.Prenom},<br><br>Voici votre QRCode de connexion :<br><img src='cid:{image.ContentId}'>";
                email.Body = builder.ToMessageBody();

                // Envoi email
                using (SmtpClient smtpClient = new SmtpClient())
                {
                    smtpClient.Connect("ssl0.ovh.net", 465, SecureSocketOptions.SslOnConnect);
                    smtpClient.Authenticate("admin@sio-savary.fr", "P@ssw0rd85!");
                    smtpClient.Send(email);
                    smtpClient.Disconnect(true);
                }
            }

            MessageBox.Show("Employé créé et email envoyé avec succès !");

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

            MessageBox.Show("Employé créé avec succès !");
            this.Close();
        }

        private void FormCreerEmployer_Load(object sender, EventArgs e)
        {

        }
    }
}
