using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Task_2_3_.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        public string PhotoName { get; set; }
        public string contentType { get; set; }
        public byte[] Photo { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        public  Category Category { get; set; }
    }
}
