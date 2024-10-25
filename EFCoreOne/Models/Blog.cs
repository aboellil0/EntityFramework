using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreOne.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int kkkk { get; set; }
        public string? Discription { get; set; }
        public int DefaultValue { get; set; }
        public DateTime DAteANdTime { get; set; }

        //[NotMapped] // way to ignore posts table to put it in database
        public List<Post> Posts { get; set; }
    }
}
