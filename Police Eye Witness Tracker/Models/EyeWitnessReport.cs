using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Police_Eye_Witness_Tracker.Models
{
    public class EyeWitnessReport
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        //[DisplayName("Phone Number")]
        [StringLength(11)]
        public string PhoneNum { get; set; }
        public string ContactAddress { get; set; }
        //[Range(1,100,ErrorMessage ="Nature of Incidence range must be between 1 and 100 only!!")]
        public string NatureofIncidence { get; set; }
        [Required]
        public string LocationofIncidence { get; set; }
        [Required]
        public string IncidenceReportNarration { get; set; }
        [Required]
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
