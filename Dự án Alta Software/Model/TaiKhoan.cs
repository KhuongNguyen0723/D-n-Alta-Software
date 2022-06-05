using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dự_án_Alta_Software.Model
{
    [Table("TaiKhoan")]
    public class TaiKhoan
    {
        [Key]
        public int id_taikhoan { get; set; }
        [Required,StringLength(50)]
        public string tentaikhoan { get; set; }
        [Required, StringLength(50)]
        public string matkhau { get; set; }
        public PhanQuyen PhanQuyen { get; set; }
    }
}
