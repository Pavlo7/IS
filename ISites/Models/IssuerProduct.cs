using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISites.Models
{
    public class IssuerProduct
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int PosIssuerId { get; set; }
        public PosIssuer PosIssuer { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int IssuerProductCode { get; set; }
    }
}
