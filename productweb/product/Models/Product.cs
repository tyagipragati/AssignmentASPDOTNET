using System.ComponentModel.DataAnnotations;

namespace product.Models
{
    public class Product
    {
        [Key]
        public int SerialNumber { get; set; }
        [Required]
        public String PartType { get; set; }
        [Required]
        public int Number { get; set; }
        public int Revision { get; set; }
        [Required]
        public String Description { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public String RefDes { get; set; }


    }
}
