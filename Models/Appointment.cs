using System.ComponentModel.DataAnnotations;

namespace AppointmentManagementApi.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required]
        public string PatientName { get; set; } = string.Empty;

        [Required]
        public string PatientContact { get; set; } = string.Empty;

        [Required]
        public DateTime AppointmentDateTime { get; set; }

        [Required]
        public int DoctorId { get; set; }

        public Doctor? Doctor { get; set; }
    }
}
