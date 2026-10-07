using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using WindowsFormsApp1;
public class AppDbContext : DbContext
{
    public DbSet<Estudiante> Estudiantes => Set<Estudiante>();
    // Ruta de BD en carpeta local del usuario
    private static string DbPath
    {
        get
        {
            var root = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "WinFormsEfDemo");
            Directory.CreateDirectory(root);
            return Path.Combine(root, "estudiantes.db");
        }
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlite($"Data Source={DbPath}");
}