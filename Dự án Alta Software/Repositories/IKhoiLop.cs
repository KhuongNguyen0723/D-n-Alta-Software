using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public interface IKhoiLop
    {
        List<KhoiLop> GetKhoiLops();

        KhoiLop GetKhoiLop(int id);
        KhoiLop AddKhoiLop(KhoiLop khoilop);

        void DeleteKhoiLop(KhoiLop khoilop);

        KhoiLop EditKhoiLop(KhoiLop khoilop);
    }
}
