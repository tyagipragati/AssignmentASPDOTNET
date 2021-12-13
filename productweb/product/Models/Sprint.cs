using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace product.Models
{
    [Table("Sprint")]
    public class Sprint
    {

        [Key]
        public int SerialNumber { get; set; }
        public String PartType { get; set; }
        [Required]
        public int Number { get; set; }
        public int Revision { get; set; }
        public String Description { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public String RefDes { get; set; }


    }
}
