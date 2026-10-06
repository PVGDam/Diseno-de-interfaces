using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace WinFormsEfCoreDemo
{
    public class AppDbContext : DbContext
    {
        public DbSet<Producto> Productos => Set<Producto>();

        private static string DbPath
        {
            get
            {
                var root = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "WinFormsEfCoreDemo");
                Directory.CreateDirectory(root);
                return Path.Combine(root, "productos.db");
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
