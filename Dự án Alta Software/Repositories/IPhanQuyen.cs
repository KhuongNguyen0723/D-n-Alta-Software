using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public interface IPhanQuyen
    {
        List<PhanQuyen> GetPhanQuyens();

        PhanQuyen GetPhanQuyen(int id);
        PhanQuyen AddPhanQuyen(PhanQuyen phanquyen);

        void DeletePhanQuyen(PhanQuyen phanquyen);

        PhanQuyen EditPhanQuyen(PhanQuyen phanquyen);
    }
}
