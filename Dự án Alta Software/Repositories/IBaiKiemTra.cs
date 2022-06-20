using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public interface IBaiKiemTra
    {
        List<BaiKiemTra> GetBaiKiemTras();

        BaiKiemTra GetBaiKiemTra(int id);
        BaiKiemTra AddBaiKiemTra(BaiKiemTra baikiemtra);

        void DeleteBaiKiemTra(BaiKiemTra baikiemtra);

        BaiKiemTra EditBaiKiemTra(BaiKiemTra baikiemtra);
    }
}
