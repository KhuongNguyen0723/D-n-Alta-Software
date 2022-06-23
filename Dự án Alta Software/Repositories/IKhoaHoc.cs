using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public interface IKhoaHoc
    {
        List<KhoaHoc> GetKhoaHocs();

        KhoaHoc GetKhoaHoc(int id);
        KhoaHoc AddKhoaHoc(KhoaHoc kh);

        void DeleteKhoaHoc(KhoaHoc kh);

        KhoaHoc EditKhoaHoc(KhoaHoc kh);
    }
}
