using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public interface IPhanCong
    {
        List<PhanCong> GetPhanCong();

        PhanCong GetPhanCong(int id);
        PhanCong AddPhanCong(PhanCong phancong);

        void DeletePhanCong(PhanCong phancong);

        PhanCong EditPhanCong(PhanCong phancong);
    }
}
