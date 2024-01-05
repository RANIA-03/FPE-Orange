using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Task_1_4_.Models
{
    public class Employee : Person
    {
        public DateTime Birthdate { get; set; }

        [Required]
        [StringLength(20)]
        public string NationalId { get; set; }

        [StringLength(20)]
        public string MaritalStatus { get; set; }

        [Required]
        public DateTime EntryDate { get; set; }
        public string Photo { get; set; }

        [Required]
        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
