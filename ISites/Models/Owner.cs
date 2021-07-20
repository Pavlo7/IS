using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISites.Models
{
    public class Owner
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int OwnerCode { get; set; }
        [Required]
        public string OwnerName { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
