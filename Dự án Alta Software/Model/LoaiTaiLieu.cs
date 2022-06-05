using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dự_án_Alta_Software.Model
{
    [Table("LoaiTaiLieu")]
    public class LoaiTaiLieu
    {
        [Key]
        public int id_loaitailieu { get; set; }
        [Required,StringLength(50)]
        public string tentailieu { get; set; }
        public int soluong { get; set; }

        public TaiLieu TaiLieu { get; set; }
    }
}
