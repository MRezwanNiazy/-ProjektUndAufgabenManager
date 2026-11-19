using Microsoft.EntityFrameworkCore;
using ProjektUndAufgabenManager.Models;

namespace ProjektUndAufgabenManager.Data;

public class AppDbContext : DbContext
{
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Project> Projects => Set<Project>();
    public DbSet<TaskItem> Tasks => Set<TaskItem>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            // Lokale SQLite-Datenbankdatei im Anwendungsverzeichnis
            optionsBuilder.UseSqlite("Data Source=ProjektManager.db");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // 1. Kategorie: Name ist Unique (Konzeption.md)
        modelBuilder.Entity<Category>()
            .HasIndex(c => c.Name)
            .IsUnique();

        // 2. Kategorie -> Projekte (1:n) mit Restrict
        // Eine Kategorie darf erst gelöscht werden, wenn ihr keine Projekte mehr zugeordnet sind.
        modelBuilder.Entity<Category>()
            .HasMany(c => c.Projects)
            .WithOne(p => p.Category)
            .HasForeignKey(p => p.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        // 3. Projekt -> Aufgaben (1:n) mit Cascade
        // Beim Löschen eines Projekts werden alle verknüpften Aufgaben automatisch kaskadierend gelöscht.
        modelBuilder.Entity<Project>()
            .HasMany(p => p.Tasks)
            .WithOne(t => t.Project)
            .HasForeignKey(t => t.ProjectId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
