using Microsoft.EntityFrameworkCore;
using RecordStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecordStore.Data
{
    public class AppDbContext:DbContext
    {
        
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
                
             }
            
            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JointDisqueArtiste>().HasKey(am => new
            {
                am.DisqueId,
                am.ArtisteId
            }); ;
            modelBuilder.Entity<JointDisqueArtiste>().HasOne(m => m.Disque).WithMany(am => am.JointDisqueArtistes).HasForeignKey(m => m.DisqueId);
            modelBuilder.Entity<JointDisqueArtiste>().HasOne(m => m.Artiste).WithMany(am => am.JointDisqueArtistes).HasForeignKey(m => m.ArtisteId);

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnectionString");
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Disque> Disques { get; set; }
        public DbSet<Artiste> Artistes { get; set; }
        public DbSet<JointDisqueArtiste> JointDisqueArtistes { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Label> Labels { get; set; }
        


    }
}
