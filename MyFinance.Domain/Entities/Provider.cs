using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entities
{
    public class Provider
    {
        [Key]
        public int IdPro { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Username { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public bool IsApproved { get; set; }
        [DataType(DataType.Password), MinLength(8), Required]
        public string Password { get; set; }
        [DataType(DataType.Password), MinLength(8), Required, NotMapped, Compare("Password")]
        public string ConfirmPassword { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
