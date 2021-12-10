using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace product.Models
{
    [Table("Gasmeter")]
    public class Gasmeter
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
