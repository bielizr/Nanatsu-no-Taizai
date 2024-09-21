using Microsoft.EntityFrameworkCore;
using Nanatsu_no_Taizai.Models;

namespace Nanatsu_no_Taizai.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Raca> Racas { get; set; }

    public DbSet<Cla> Clas { get; set; }

    public DbSet<Personagem> Personagens { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Raca>()
            .HasKey(r => r.Id);

        builder.Entity<Cla>()
            .HasKey(c => c.Id);

        builder.Entity<Personagem>()
            .HasKey(p => p.Id);

        builder.Entity<Personagem>()
            .HasOne(p => p.Raca)
            .WithMany(r => r.Personagens)
            .HasForeignKey(p => p.id_raca)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Personagem>()
            .HasOne(p => p.Cla)
            .WithMany(c => c.Personagens)
            .HasForeignKey(p => p.id_cla)
            .OnDelete(DeleteBehavior.SetNull);
    }
}

