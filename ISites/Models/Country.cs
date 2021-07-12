using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISites.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Code_A2 { get; set; }
        public string Code_A3 { get; set; }
        public int Code_Num { get; set; }
        public string Name { get; set; }
        public string Name_RU { get; set; }
        public string Currency { get; set; }
    }
}
