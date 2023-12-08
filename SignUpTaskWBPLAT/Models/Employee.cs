using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace SignUpTaskWBPLAT.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PinCode { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string PanNumber { get; set; }

        public string AdharNumber { get; set; }
     
    }
}
