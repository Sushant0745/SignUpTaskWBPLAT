using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SignUpTaskWBPLAT.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]

        public string Gender { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [Required]
        [StringLength(100)]
        public string City { get; set; }

        [Required]
        [StringLength(100)]
        public string State { get; set; }

        [Required]
        [RegularExpression(@"^\d{6}$", ErrorMessage = "PinCode must be 6 digits.")]

        public string PinCode { get; set; }

        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Mobile number must be 10 digits.")]

        public string Mobile { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Pan number must be 10 digits.")]
        public string PanNumber { get; set; }

        [Required]
        [RegularExpression(@"^\d{12}$", ErrorMessage = "Aadhar number must be 12 digits.")]
        public string AdharNumber { get; set; }



    }
}
