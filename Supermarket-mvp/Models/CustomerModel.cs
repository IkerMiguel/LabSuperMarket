using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Supermarket_mvp.Models
{
    internal class CustomerModel
    {
        [DisplayName("Customer Id")]
        public int Id { get; set; }

        [DisplayName("Customer Document")]
        [Required(ErrorMessage = "Customer Document is required")]
        [StringLength(15, ErrorMessage = "Customer Document must be 15 characters")]
        public string Document { get; set; }

        [DisplayName("Customer FirstName")]
        [Required(ErrorMessage = "Customer FirstName is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customer FirstName must be between 3 and 50 characters")]
        public string FirstName { get; set; }

        [DisplayName("Customer LastName")]
        [Required(ErrorMessage = "Customer LastName is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customer LastName must be between 3 and 50 characters")]
        public string LastName { get; set; }

        [DisplayName("Customer Address")]
        [Required(ErrorMessage = "Customer Address is required")]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "Customer Address must be between 3 and 80 characters")]
        public string Address { get; set; }

        [DisplayName("Customer Birthday")]
        [Required(ErrorMessage = "Customer Birthday is required")]
        public DateTime? Birthday { get; set; }

        [DisplayName("Customer PhoneNumber")]
        [Required(ErrorMessage = "Customer PhoneNumber is required")]
        [StringLength(16, MinimumLength = 3, ErrorMessage = "Customer PhoneNumber must be between 3 and 16 characters")]
        public string PhoneNumber { get; set; }

        [DisplayName("Customer Email")]
        [Required(ErrorMessage = "Customer Email is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Customer Email must be between 3 and 100 characters")]
        public string Email { get; set; }

    }
}
