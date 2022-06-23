using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public interface IGiangVien
    {
        List<GiangVien> GetGiangViens();

        GiangVien GetGiangVien(int id);
        GiangVien AddGiangVien(GiangVien gv);

        void DeleteGiangVien(GiangVien gv);

        GiangVien EditGiangVien(GiangVien gv);
    }
}
