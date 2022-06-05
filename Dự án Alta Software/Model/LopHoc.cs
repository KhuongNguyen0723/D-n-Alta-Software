using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dự_án_Alta_Software.Model
{
    [Table("LopHoc")]
    public class LopHoc
    {
        [Key]
        public int id_lophoc { get; set; }
        public string tenlophoc { set; get; }
        [Required]
        public DateTime thoigian { get; set; }
        [Required,StringLength(50)]
        public string chude { get; set; }
        [Required,StringLength(50)]
        public string monhoc { get; set; }
        [Required,StringLength(50)]
        public string giangvien { get; set; }
        [Required, StringLength(50)]
        public string trangthai { get; set; }
        [Required, StringLength(50)]
        public string link_online { get; set; }
        [Required, StringLength(50)]
        public string matkhau { get; set; }
        public MonHoc MonHoc { get; set; }
    }
}
