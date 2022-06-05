using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dự_án_Alta_Software.Model
{
    [Table("HocSinh")]
    public class HocSinh
    {
        [Key]
        public int id_hocsinh { get; set; }
        [Required,StringLength(50)]
        public string hoten { get; set; }
        [Required]
        public  DateTime namsinh { get; set; }
        [Required, StringLength(100)]
        public string diachi { get; set; }
        [Required]
        [Phone]
        public int sdt { get; set; }
        [Required, StringLength(50)]
        [EmailAddress]
        public string email { get; set; }
        public TaiKhoan TaiKhoan { get; set; }
    }
}
