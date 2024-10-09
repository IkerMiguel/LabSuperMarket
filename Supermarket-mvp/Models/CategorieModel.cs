using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class CategorieModel
    {
        [DisplayName("Categorie Id")]
        public int Id { get; set; }

        [DisplayName("Categorie Name")]
        [Required(ErrorMessage = "Categorie Name is required")]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "Categorie Name must be between 3 and 80 characters")]
        public string Name { get; set; }
        [DisplayName("Description")]
        [Required(ErrorMessage = "Description is required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Description be between 2 and 60 characters")]
        public string Description { get; set; }
    }
}
