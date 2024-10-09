using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Supermarket_mvp.Models
{
    internal class PayModeModel
    {
        [DisplayName("Pay mode Id")]
        public int Id { get; set; }

        [DisplayName("Pay mode Name")]
        [Required(ErrorMessage = "Pay mode Name is required")]
        [StringLength(50,MinimumLength = 3, ErrorMessage = "Pay mode name must be between 3 and 50 characters")]
        public string Name { get; set; }
        [DisplayName("Observation")]
        [Required(ErrorMessage = "Observation is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Observation be between 2 and 200 characters")]
        public string Observation { get; set; }
    }
}
