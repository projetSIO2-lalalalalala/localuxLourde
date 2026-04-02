    using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace localux.Models;

public partial class MonDbContext : DbContext
{
    public MonDbContext() { }

    public MonDbContext(DbContextOptions<MonDbContext> options): base(options)
    {
    }

    public virtual DbSet<Client> Client { get; set; }
    public virtual DbSet<Composant> Composant { get; set; }
    public virtual DbSet<Destination> Destination { get; set; }
    public virtual DbSet<DommageControle> DommageControle { get; set; }
    public virtual DbSet<Employe> Employe { get; set; }
    public virtual DbSet<FormuleSansChauffeur> FormuleSansChauffeur { get; set; }
    public virtual DbSet<HistoriqueMdp> HistoriqueMdp { get; set; }
    public virtual DbSet<Location> Location { get; set; }
    public virtual DbSet<LogConnexion> LogConnexion { get; set; }
    public virtual DbSet<Modele> Modele { get; set; }
    public virtual DbSet<TypeDommage> TypeDommage { get; set; }
    public virtual DbSet<Vehicule> Vehicule { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql(
            "server=192.168.57.200;database=localux;user=bdd;password=P@ssw0rd;sslmode=none",
            Microsoft.EntityFrameworkCore.ServerVersion.Parse("11.8.6-mariadb")
        );

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Collation globale
        modelBuilder
            .UseCollation("utf8mb4_uca1400_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Location>()
            .HasDiscriminator<string>("type")
            .HasValue<LocationSansChauffeur>("LocationSansChauffeur")
            .HasValue<LocationAvecChauffeur>("LocationAvecChauffeur");


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
