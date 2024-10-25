using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTwoN.Models
{
    public class OneToOneP
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public OneToOneCh OneToOneCh { get; set; }
    }

    public class OneToOneCh
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ParentForignKey { get; set; }
        public OneToOneP OneToOneP { get; set; }
    }
}
