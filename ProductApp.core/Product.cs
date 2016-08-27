using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ProductApp.core
{
  public class Product
    {
      [Key]
        public int id { get; set; }
        public int ProdId { get; set; }
      [Required]
      [MaxLength(100)]
        public string ProductName { get; set; }
      [Required]
        public double ProductPrice { get; set; }
        public bool Instock { get; set; }
    }
}
