namespace Data
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using System;
    public class ContextDB : DbContext, IContextDB
    {
        private string _connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ITSense;Data Source=DESKTOP-7CF1BV6";

        public ContextDB(DbContextOptions options) : base(options) { }
        public ContextDB() { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!String.IsNullOrEmpty(_connectionString))
                options.UseSqlServer(_connectionString);
            base.OnConfiguring(options);
        }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Defectuosos> Defectuosos { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
    }
}
