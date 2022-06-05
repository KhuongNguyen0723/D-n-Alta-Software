using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dự_án_Alta_Software.Model
{
    [Table("PhanCong")]
    public class PhanCong
    {
        [Key]
        public int id_phancong { get; set; }
        [Required,StringLength(50)]
        public string tenbang { get; set; }
        [Required]
        public DateTime thoigian { get; set; }
        [Required]
        public int sotiet { get; set; }
        public GiangVien GiangVien { get; set; }
    }
}
