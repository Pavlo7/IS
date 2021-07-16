using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISites.Models
{
    public class Pos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string PosCode { get; set; }
        [Required]
        public string PosName { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }

        public List<Issuer> Issuers { get; set; } = new List<Issuer>();
    }
}
