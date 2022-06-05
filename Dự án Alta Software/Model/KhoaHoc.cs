using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dự_án_Alta_Software.Model
{
    [Table("KhoaHoc")]
    public class KhoaHoc
    {
        [Key]
        public int id_khoahoc { get; set; }
        [Required,StringLength(50)]
        public string tenkhoahoc { get; set; }
        [Required]
        public DateTime ngaybatdau { get; set; }
        [Required]
        public DateTime ngayketthuc { get; set; }
        [Required]
        public int hocky { get; set; }
        public LopHoc LopHoc { get; set; }
        public TaiKhoan TaiKhoan { get; set; }

    }
}
