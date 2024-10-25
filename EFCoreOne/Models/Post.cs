using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreOne.Models
{
    //[Table("Aboellil")] ///rename the table what ever you want
    public class Post
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [Comment("Aboellil is 3amk")] //to add comment to daatbase
        public string? Description { get; set; }
        public Blog Blog { get; set; }
    }
}
