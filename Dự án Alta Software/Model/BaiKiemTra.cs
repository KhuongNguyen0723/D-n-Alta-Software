using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dự_án_Alta_Software.Model
{
    [Table("BaiKiemTra")]
    public class BaiKiemTra
    {
        [Key]
        public int id_baikiemtra { get; set; }
        [Required,StringLength(50)]
        public string tenmon { get; set; }
        [Required, StringLength(100)]
        public string noidungkiemtra { get; set; }
        public string lich { get; set; }
        [Required, StringLength(50)]
        public string giangvien { get; set; }
        [Required]
        public DateTime ngaylambai { get; set; }
        [Required]
        public DateTime thoigian { get; set; }
        [Required, StringLength(50)]
        public string tinhtrang { get; set; }
        [StringLength(50)]
        public string bailam { get; set; }
       
        public LoaiBaiKiemTra LoaiBaiKiemTra { get; set; }
    }
}
