using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTwoN.Models
{
    public class ManytoManyP
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ManytoManyCh> manytoManyChes { get; set; }
    }
    public class ManytoManyCh
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ManytoManyP> manytoManyPs { get; set; }
    }
}
