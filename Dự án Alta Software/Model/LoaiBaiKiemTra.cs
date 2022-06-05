using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dự_án_Alta_Software.Model
{
    [Table("LoaiBaiKiemTra")]
    public class LoaiBaiKiemTra
    {
        [Key]
        public int id_loaibaikiemtra { get; set; }
        [Required,StringLength(50)]
        public string tenloai { get; set; }
        [StringLength(50)]
        public string baikiemtrasaptoi { get; set; }
        [StringLength(50)]
        public string baidahoanthanh { get; set; }
        [StringLength(50)]
        public string baichuahoanthanh { get; set; }
    }
}
