using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dự_án_Alta_Software.Model
{
    [Table("PhanQuyen")]
    public class PhanQuyen
    {
        [Key]
        public int id_quyen { get; set; }
        [Required,StringLength(50)]
        public string tenquyen { get; set; }
    }
}
