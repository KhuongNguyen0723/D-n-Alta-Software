using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public interface ILopHoc
    {
        List<LopHoc> GetLopHocs();

        LopHoc GetLopHoc(int id);
        LopHoc AddLopHoc(LopHoc lophoc);

        void DeleteLopHoc(LopHoc lophoc);

        LopHoc EditLopHoc(LopHoc lophoc);
    }
}
