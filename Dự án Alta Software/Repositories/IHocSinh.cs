using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public interface IHocSinh
    {
        List<HocSinh> GetHocSinhs();

        HocSinh GetHocSinh(int id);
        HocSinh AddHocSinh(HocSinh hs);

        void DeleteHocSinh(HocSinh hs);

        HocSinh EditHocSinh(HocSinh hs);
    }
}
