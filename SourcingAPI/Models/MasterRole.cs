using System.ComponentModel.DataAnnotations;

namespace SourcingAPI.Models
{
    public class MasterRole
    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        public string RoleName { get; set; }

        public string Permission { get; set; }
    }
}
