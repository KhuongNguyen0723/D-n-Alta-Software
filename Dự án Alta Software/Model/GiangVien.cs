using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dự_án_Alta_Software.Model
{
    [Table("GiangVien")]
    public class GiangVien
    {
        [Key]
        public int id_giangvien { get; set; }
        [Required,StringLength(50)]
        public string tengiangvien { get; set; }
        [Required,Phone]
        public int sdt { get; set; }
        [Required,EmailAddress]
        public string email { get; set; }
        public TaiKhoan TaiKhoan { get; set; }
    }
}
