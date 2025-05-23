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
        public string Address { get; set; }

        [Required]
        public string PrincipalFirstName { get; set; }

        [Required]
        public string PrincipalLastName { get; set; }

        [EmailAddress]
        public string PrincipalEmail { get; set; }

        [Phone]
        public string PrincipalPhone { get; set; }

        [Required]
        public string DistrictName { get; set; }
    }
}
