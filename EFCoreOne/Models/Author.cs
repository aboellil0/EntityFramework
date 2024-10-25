using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreOne.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string FullName { get; set; }
    }
}
