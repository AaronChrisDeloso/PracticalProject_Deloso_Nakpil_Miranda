using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using PracticalProject_Deloso_Nakpil_Miranda.Model;
using System.IO;


namespace PracticalProject_Deloso_Nakpil_Miranda.Services
{
    public class DatabaseContext : DbContext
    {
        public DbSet<DatabaseContext> Animals { get; set; }

        public DatabaseContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuiler)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Animal.db");
            optionsBuiler.UseSqlite($"Filename={dbPath}");
        }
    }
}
