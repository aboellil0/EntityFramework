using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreOne.Models
{
    public class BLogEntity
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }
        [Column("Disc")]
        [MaxLength(50)]
        public string Description { get; set; }
    }
}
