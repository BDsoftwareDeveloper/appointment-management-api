using System.ComponentModel.DataAnnotations;

namespace AppointmentManagementApi.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
