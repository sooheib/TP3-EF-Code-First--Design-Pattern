using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entities
{
    public class Product
    {
        public int Ahmed { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name = "Production Date : ")]
        public DateTime DateProd { get; set; }
        [Required(ErrorMessage = "Champ Obligatoire!!")]
        [StringLength(25)]//s'applique sur l'interface web
        [MaxLength(50)]//s'applique au niveau du DB
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [DataType(DataType.Currency)]
        public double Prix { get; set; }
        [Range(0,1000)]
        public int Quantity { get; set; }
        //foreing keys
        [ForeignKey("Category")]
        public int? CategoryFk { get; set; }//? = nullable
        public Category Category { get; set; }
        public ICollection<Provider> Providers { get; set; }

        public int? CategoryId { get; set; }


    }
}
