using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dự_án_Alta_Software.Model
{
    [Table("Diem")]
    public class Diem
    {
        [Key]
        public int id_diem { get; set; }
        [Required,StringLength(50)]
        public string tenmonhoc { get; set; }
        [Required, StringLength(50)]
        public string tengiangvien { get; set; }
        [Required]
        public double diemchuyencan { get; set; }
        [Required]
        public double kiemtramieng { get; set; }
        [Required]
        public double heso2 { get; set; }
        [Required]
        public double heso3 { get; set; }
        [Required]
        public double diemtrungbinh { get; set; }
        [Required]
        public double diemtongket { get; set; }
        [Required,StringLength(50)]
        public string ketqua { get; set; }
        [Required, StringLength(50)]
        public string danhgia { get; set; }
        [Required]
        public DateTime ngaycapnhat { get; set; }
        public MonHoc MonHoc { get; set; }
       


    }
}
