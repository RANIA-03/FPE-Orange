using System.ComponentModel.DataAnnotations;

namespace Task_2_3_.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual List<Product> Products { get; set; }

        public string PhotoName { get; set; }
        public string contentType { get; set; }
        public byte[] Photo { get; set; }
    }
}
