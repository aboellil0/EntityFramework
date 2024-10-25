using EFCoreTwoN.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTwoN
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MOHAMED-ABOELLI;Database=EFCoreTwo;Trusted_Connection=True;Encrypt=false");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OneToOneP>()
                .HasOne(p => p.OneToOneCh)
                .WithOne(p => p.OneToOneP)
                .HasForeignKey<OneToOneCh>(b => b.ParentForignKey);


            modelBuilder.Entity<OnetoManyP>()
                .HasMany(p => p.onetoManyChes)
                .WithOne(p => p.onetoManyP)
                .HasForeignKey(p => p.OnetoManyForignKey)
                .HasPrincipalKey(p => p.PrKey);

            modelBuilder.Entity<ManytoManyP>()
                .HasMany(p => p.manytoManyChes)
                .WithMany(p => p.manytoManyPs)
                .UsingEntity(p => p.ToTable("ManytoMany"));

            modelBuilder.Entity<Post>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Posts)
                .UsingEntity<PostTag>(
                    l => l.HasOne<Tag>(e => e.Tag).WithMany(e => e.PostTags).HasForeignKey(e => e.TagForeignKey),
                    r => r.HasOne<Post>(e => e.Post).WithMany(e => e.PostTags).HasForeignKey(e => e.PostForeignKey),
                    j => j.HasKey(e => new { e.PostForeignKey,e.TagForeignKey})
                );

            modelBuilder.Entity<Blog>()
                .HasIndex(p => p.Url) //coulmn to be index 
                .IsUnique() //make it unique
                .HasDatabaseName("Mohamed_Index") //change defult name
                .HasFilter(null); //make it accept nullbale values


            modelBuilder.HasSequence<int>("MohamedSeq"); //create a sequence 
            modelBuilder.Entity<Seq>()
                .Property(p => p.SeqNumber)
                .HasDefaultValueSql("NEXT VALUE FOR MohamedSeq"); //setup the sequence in this column


            modelBuilder.Entity<DataToSend>()
                .HasData(new DataToSend { Id = 1, Name = "mohamed", Description = "aboellil" });
        }

        public DbSet<DataToSend> DataToSends { get; set; }
    }
}