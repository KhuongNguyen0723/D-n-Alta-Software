using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public class LoaiBaiKiemTraRepository : ILoaiBaiKiemTra
    {
        private List<LoaiBaiKiemTra> lbkts = new List<LoaiBaiKiemTra>();
        public LoaiBaiKiemTra AddLoaiBaiKiemTra(LoaiBaiKiemTra lbkt)
        {
            lbkt.id_loaibaikiemtra = new LoaiBaiKiemTra().id_loaibaikiemtra;
            lbkts.Add(lbkt);
            return lbkt;
        }

        public void DeleteLoaiBaiKiemTra(LoaiBaiKiemTra lbkt)
        {
            lbkts.Remove(lbkt);
        }

        public LoaiBaiKiemTra EditLoaiBaiKiemTra(LoaiBaiKiemTra lbkt)
        {
            var lbkts = GetLoaiBaiKiemTra(lbkt.id_loaibaikiemtra);
            lbkts.baikiemtrasaptoi = lbkt.baikiemtrasaptoi;
            lbkts.baidahoanthanh = lbkt.baidahoanthanh;
            lbkts.baichuahoanthanh = lbkt.baichuahoanthanh;
            return lbkts;
        }

        public LoaiBaiKiemTra GetLoaiBaiKiemTra(int id)
        {
            return lbkts.SingleOrDefault(x => x.id_loaibaikiemtra == id);
        }

        public List<LoaiBaiKiemTra> GetLoaiBaiKiemTras()
        {
            return lbkts;
        }
    }
}
