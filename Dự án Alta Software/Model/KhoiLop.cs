using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dự_án_Alta_Software.Model
{
    [Table("KhoiLop")]
    public class KhoiLop
    {
        [Key]
        public int id_khoilop { get; set; }
        [Required,StringLength(50)]
        public string tenkhoi { get; set; }

        public LopHoc LopHoc { get; set; }
       
    }
}
