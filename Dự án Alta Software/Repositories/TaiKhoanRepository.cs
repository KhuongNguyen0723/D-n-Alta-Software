using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public class TaiKhoanRepository : ITaiKhoan
    {

        private List<TaiKhoan> taikhoan = new List<TaiKhoan>()
        {
            new TaiKhoan()
            {
                id_taikhoan = 1,
                tentaikhoan ="admin",
                matkhau ="admin"
            },
             new TaiKhoan()
            {
                id_taikhoan = 2,
                tentaikhoan ="user",
                matkhau ="user"
            },
        };
        public TaiKhoan AddTaiKhoan(TaiKhoan taiKhoan)
        {
            taiKhoan.id_taikhoan = new TaiKhoan().id_taikhoan;
            taikhoan.Add(taiKhoan);
            return taiKhoan;
        }

        public void DeleteTaiKhoan(TaiKhoan taiKhoan)
        {
            taikhoan.Remove(taiKhoan);
        }

        public TaiKhoan EditTaiKhoan(TaiKhoan taiKhoan)
        {
            var existingTaiKhoan = GetTaiKhoan(taiKhoan.id_taikhoan);
            existingTaiKhoan.tentaikhoan = taiKhoan.tentaikhoan;
            return existingTaiKhoan;
        }

        public TaiKhoan GetTaiKhoan(int id)
        {
            return taikhoan.SingleOrDefault(x => x.id_taikhoan == id);
        }

        public List<TaiKhoan> GetTaiKhoans()
        {
            return taikhoan;
        }
    }
}
