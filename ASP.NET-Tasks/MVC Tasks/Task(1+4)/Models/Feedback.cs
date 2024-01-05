using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Task_1_4_.Models
{
    public class Feedback
    {
        [Key]
        public int FeedbackId { get; set; }

        [Required]
        public string Message { get; set; }
        
        [ForeignKey("Id")]
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }

        
    }
}
