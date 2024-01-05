using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Task_1_4_.Models
{
    public class Tasks
    {
        [Key]
        public int TaskId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        public string Description { get; set; }

        public int ImportanceLevel { get; set; }

        [ForeignKey("Id")]
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [ForeignKey("Id")]
        public string ManagerId { get; set; }
        public Manager Manager { get; set; }
    }
}
