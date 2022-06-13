using Dự_án_Alta_Software.Data;
using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public class TaiKhoanImpcs : ITaiKhoanRepository
    {
        private DataContext dataContext;

        public TaiKhoanImpcs(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public TaiKhoan AddTaiKhoan(TaiKhoan taiKhoan)
        {
            taiKhoan.id_taikhoan = new TaiKhoan().id_taikhoan;
            dataContext.TaiKhoans.Add(taiKhoan);
            dataContext.SaveChanges();
            return taiKhoan;
        }

        public void DeleteTaiKhoan(TaiKhoan taiKhoan)
        {
           dataContext.TaiKhoans.Remove(taiKhoan);
            dataContext.SaveChanges();
        }

        public TaiKhoan EditTaiKhoan(TaiKhoan taiKhoan)
        {
            var existingTaiKhoan = dataContext.TaiKhoans.Find(taiKhoan.id_taikhoan);
            if(existingTaiKhoan != null)
            {
                existingTaiKhoan.tentaikhoan = taiKhoan.tentaikhoan;
                dataContext.TaiKhoans.Update(taiKhoan);
                dataContext.SaveChanges();
            }
            return taiKhoan;
        }

        public TaiKhoan GetTaiKhoan(int id)
        {
            var taiKhoan = dataContext.TaiKhoans.Find(id);
            return taiKhoan;
        }

        public List<TaiKhoan> GetTaiKhoans()
        {
            return dataContext.TaiKhoans.ToList();
        }
    }
}
