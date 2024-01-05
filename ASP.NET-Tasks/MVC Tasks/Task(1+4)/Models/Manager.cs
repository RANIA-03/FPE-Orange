using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Task_1_4_.Models
{
    public class Manager : Person
    {
        public string SSN { get; set; }
    }
}
