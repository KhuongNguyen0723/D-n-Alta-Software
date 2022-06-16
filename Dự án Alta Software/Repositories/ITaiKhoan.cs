using Dự_án_Alta_Software.Model;
namespace Dự_án_Alta_Software.Repositories
{
    public interface ITaiKhoan
    {
        List<TaiKhoan> GetTaiKhoans();

        TaiKhoan GetTaiKhoan(int id);
        TaiKhoan AddTaiKhoan(TaiKhoan taiKhoan);

        void DeleteTaiKhoan(TaiKhoan taiKhoan);

        TaiKhoan EditTaiKhoan(TaiKhoan taiKhoan);
    }
}
