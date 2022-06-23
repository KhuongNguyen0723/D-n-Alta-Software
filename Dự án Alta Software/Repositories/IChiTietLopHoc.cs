using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public interface IChiTietLopHoc
    {
        List<ChiTietLopHoc> GetChiTietLopHocs();

        ChiTietLopHoc GetChiTietLopHoc(int id);
        ChiTietLopHoc AddChiTietLopHoc(ChiTietLopHoc ctlh);

        void DeleteChiTietLopHoc(ChiTietLopHoc ctlh);

        ChiTietLopHoc EditChiTietLopHoc(ChiTietLopHoc ctlh);
    }
}
