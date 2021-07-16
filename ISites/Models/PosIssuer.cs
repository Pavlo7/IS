using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISites.Models
{
    public class PosIssuer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int PosId { get; set; }
        public Pos Pos { get; set; }

        public int IssuerId { get; set; }
        public Issuer Issuer { get; set; }

        public int IssuerPosCode { get; set; }
    }
}
