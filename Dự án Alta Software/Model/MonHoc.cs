using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dự_án_Alta_Software.Model
{
    [Table("MonHoc")]
    public class MonHoc
    {
        [Key]
        public int id_monhoc { get; set; }
        [Required,StringLength(50)]
        public string tenmonhoc { get; set; }

      
        
        public BaiKiemTra BaiKiemTra { get; set; }
       
    }
}
