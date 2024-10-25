using EFCoreOne.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreOne.Configration
{
    public class BlogEntityConfigration : IEntityTypeConfiguration<Blog>
    {
        //دي طريقة عشان تخلي property معينة required 
        public void Configure(EntityTypeBuilder<Blog> builder) 
        {
            builder.Property(m => m.Discription).IsRequired();
        }
    }
}
