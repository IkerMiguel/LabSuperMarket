using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Supermarket_mvp.Models
{
    class ProductModel
    {
        [DisplayName("Product Id")]
        public int Id { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product Name is required")]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "Product Name must be between 3 and 80 characters")]
        public string Name { get; set; }

        [DisplayName("Product Price")]
        [Required(ErrorMessage = "Product Price is required")]
        public int Price { get; set; }
        [DisplayName("Product Stock")]
        [Required(ErrorMessage = "Product Stock is required")]
        public int Stock { get; set; }
        [DisplayName("Categorie")]
        [Required(ErrorMessage = "Categorie is required")]
        public int CategorieId { get; set; }
    }
}
