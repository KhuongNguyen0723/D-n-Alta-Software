using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public interface IMonHoc
    {
        List<MonHoc> GetMonHoc();

        MonHoc GetMonHoc(int id);
        MonHoc AddMonHoc(MonHoc monhoc);

        void DeleteMonHoc(MonHoc monhoc);

        MonHoc EditMonHoc(MonHoc monhoc);
    }
}
