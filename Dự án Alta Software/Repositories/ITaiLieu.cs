using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public interface ITaiLieu
    {
        List<TaiLieu> GetTaiLieu();

        TaiLieu GetTaiLieu(int id);
        TaiLieu AddTaiLieu(TaiLieu tailieu);

        void DeleteTaiLieu(TaiLieu tailieu);

        TaiLieu EditTaiLieu(TaiLieu tailieu);
    }
}
