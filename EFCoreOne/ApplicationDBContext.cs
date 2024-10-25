using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EFCoreOne.Models;
using EFCoreOne.Configration;

namespace EFCoreOne
{
    public class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MOHAMED-ABOELLI;Database=EFCore;Trusted_Connection=True;Encrypt=false");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //طريقة عشان تضيف ال class ل database
            modelBuilder.Entity<BLogEntity>();
            //way to ignore posts table to put it in database
            modelBuilder.Ignore<Post>();
            new BlogEntityConfigration().Configure(modelBuilder.Entity<Blog>());
            // Exclude table From Migrations
            // التابل هيفضل موجود في الدتا باز بس اي تعديل يحصل بعد كده عليه من الentity framwork مش هينتج عليع تعديل في الداتا باس
            //modelBuilder.Entity<Blog>().ToTable("Blogs", b => b.ExcludeFromMigrations());
            //modelBuilder.Entity<Post>().ToTable("Aboelllil");
            //change coulnm name
            modelBuilder.Entity<Blog>().Property(p => p.Discription).HasColumnName("Disc");
            //change column type
            modelBuilder.Entity<Blog>().Property(p => p.Name).HasColumnType("nvarchar(200)");
            //to select a coulmn as Id and change his name
            modelBuilder.Entity<Author>().HasKey(p => p.Id);
            modelBuilder.Entity<Blog>().HasKey(p => p.Id).HasName("MohamedId");
            //set default value to property
            modelBuilder.Entity<Blog>().Property(p => p.DefaultValue).HasDefaultValue(255);
            modelBuilder.Entity<Blog>().Property(p => p.DAteANdTime).HasDefaultValueSql("GETDATE()");
            //create a Computed Columns
            modelBuilder.Entity<Author>().Property(p => p.FullName).HasComputedColumnSql("[FName] + ', ' + [LName]");
        }
        //طريقة عشان تضيف ال class ل database
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Author> Authors { get; set;}
        //////////////////////////////////////
    }
}
