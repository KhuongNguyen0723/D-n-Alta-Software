using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dự_án_Alta_Software.Model
{
    [Table("TaiLieu")]
    public class TaiLieu
    {
        [Key]
        public int id_tailieu { get; set; }
        [Required, StringLength(50)]
        public string tentailieu { get; set; }
        [Required]
        public int sotrang { get; set; }
        [Required]
        public string noidung { get; set; }
        [Required,StringLength(50)]
        public string nguoibiensoan { get; set; }
        public GiangVien GiangVien { get; set; }
    }
}
