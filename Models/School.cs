using System.ComponentModel.DataAnnotations;

namespace MaintenancePortal.Models
{
    public class School
    {
        public int Id { get; set; }

        [Required]
        public string SchoolName { get; set; }

        [Required]
        public string EMISNumber { get; set; }

        [Required]
        public string SchoolAddress { get; set; }

        // Principal Info
        public string PrincipalFirstName { get; set; }
        public string PrincipalLastName { get; set; }
        public string PrincipalEmail { get; set; }
        public string PrincipalPhoneNumber { get; set; }

        public string DistrictName { get; set; }
    }
}
