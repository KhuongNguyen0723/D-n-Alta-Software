using Dự_án_Alta_Software.Model;
using Microsoft.EntityFrameworkCore;

namespace Dự_án_Alta_Software.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options) { }
        public DbSet<BaiKiemTra> BaiKiemTras { get; set; }
        public DbSet<ChiTietLopHoc> ChiTietLopHocs { get; set; }
        public DbSet<Diem> Diems { get; set; }
        public DbSet<GiangVien> GiangViens { get; set; }
        public DbSet<HocSinh> HocSinhs { get; set; }
        public DbSet<KhoaHoc> KhoaHocs { get; set; }
        public DbSet<KhoiLop> KhoiLops { get; set; }
        public DbSet<LoaiBaiKiemTra> LoaiBaiKiemTras { get; set; }
        public DbSet<LoaiTaiLieu> LoaiTaiLieus { get; set; }
        public DbSet<LopHoc> LopHocs { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<PhanCong> PhanCongs { get; set; }
        public DbSet<PhanQuyen> PhanQuyens { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<TaiLieu> TaiLieus { get; set; }
       
    }
}
