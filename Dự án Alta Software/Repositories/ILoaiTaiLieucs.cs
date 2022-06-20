using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public interface ILoaiTaiLieucs
    {
        List<LoaiTaiLieu> GetLoaiTaiLieu();

        LoaiTaiLieu GetLoaiTaiLieu(int id);
        LoaiTaiLieu AddLoaiTaiLieu(LoaiTaiLieu loaitailieu);

        void DeleteLoaiTaiLieu(LoaiTaiLieu loaitailieu);

        LoaiTaiLieu EditLoaiTaiLieu(LoaiTaiLieu loaitailieu);
    }
}
