using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebPlatAPIClient.Models
{
    public class EmployeeModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        [Required]
        [StringLength(255)]

        public string Name { get; set; }

        [JsonPropertyName("gender")]
        [Required]

        public string Gender { get; set; }

        [JsonPropertyName("address")]
        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [JsonPropertyName("city")]
        [Required]
        [StringLength(100)]
        public string City { get; set; }

        [JsonPropertyName("state")]
        [Required]
        [StringLength(100)]
        public string State { get; set; }

        [JsonPropertyName("pinCode")]
        [Required]
        [RegularExpression(@"^\d{6}$", ErrorMessage = "PinCode must be 6 digits.")]

        public string PinCode { get; set; }

        [JsonPropertyName("mobile")]
        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Mobile number must be 10 digits.")]

        public string Mobile { get; set; }

        [JsonPropertyName("email")]
        [Required]
        public string Email { get; set; }

        [JsonPropertyName("panNumber")]
        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Pan number must be 10 digits.")]
        public string PanNumber { get; set; }

        [JsonPropertyName("adharNumber")]
        [Required]
        [RegularExpression(@"^\d{12}$", ErrorMessage = "Aadhar number must be 12 digits.")]
        public string AdharNumber { get; set; }



    }

}
