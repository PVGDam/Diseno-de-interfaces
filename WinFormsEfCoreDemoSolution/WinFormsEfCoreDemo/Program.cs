using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace WinFormsEfCoreDemo
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
