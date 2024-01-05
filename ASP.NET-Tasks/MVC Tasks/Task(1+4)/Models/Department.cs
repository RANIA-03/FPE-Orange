using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Task_1_4_.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required]
        public string DepartmentName { get; set; }
      
        [Required]
        [ForeignKey("Id")]
        public string ManagerId { get; set; }
        public Manager Manager { get; set; }
    }
}
