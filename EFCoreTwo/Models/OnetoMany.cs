using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTwoN.Models
{
    public class OnetoManyP
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PrKey { get; set; }
        public List<OnetoManyCh> onetoManyChes { get; set; }
    }
    public class OnetoManyCh
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public string Description { get; set; }
        public int OnetoManyForignKey { get; set; }
        public OnetoManyP onetoManyP { get; set; }
    }
}
