using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dự_án_Alta_Software.Model
{
    [Table("ChiTietLopHoc")]
    [Keyless]
    public class ChiTietLopHoc
    {
        
      public LopHoc LopHoc { get; set; }
        [Required,StringLength(50)]
        public string lopsapmo { get; set; }
        [Required]
        public int lopdahoanthanh { get; set; }

        [Required]
        public int lopchuahoanthanh { get; set; }



    }
}
