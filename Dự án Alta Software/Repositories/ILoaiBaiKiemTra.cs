using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public interface ILoaiBaiKiemTra
    {
        List<LoaiBaiKiemTra> GetLoaiBaiKiemTras();

        LoaiBaiKiemTra GetLoaiBaiKiemTra(int id);
        LoaiBaiKiemTra AddLoaiBaiKiemTra(LoaiBaiKiemTra lbkt);

        void DeleteLoaiBaiKiemTra(LoaiBaiKiemTra lbkt);

        LoaiBaiKiemTra EditLoaiBaiKiemTra(LoaiBaiKiemTra lbkt);
    }
}
