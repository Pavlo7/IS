using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISites.Models
{
    public class Country
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Code_A2 { get; set; }
        [Required]
        public string Code_A3 { get; set; }
        public int Code_Num { get; set; }
        [Required]
        public string Name { get; set; }
        public string Name_RU { get; set; }
        public string Currency { get; set; }

        public List<Owner> Owners { get; set; } = new List<Owner>(); 
    }
}
