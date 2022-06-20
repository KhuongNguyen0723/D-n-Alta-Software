using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
   
    public class BaiKiemTraRepository : IBaiKiemTra
    {
        private List<BaiKiemTra> bkts = new List<BaiKiemTra>();
        public BaiKiemTra AddBaiKiemTra(BaiKiemTra baikiemtra)
        {
            baikiemtra.id_baikiemtra = new BaiKiemTra().id_baikiemtra;
            bkts.Add(baikiemtra);
            return baikiemtra;
        }

        public void DeleteBaiKiemTra(BaiKiemTra baikiemtra)
        {
            bkts.Remove(baikiemtra);
        }

        public BaiKiemTra EditBaiKiemTra(BaiKiemTra baikiemtra)
        {
            var existingBKT = GetBaiKiemTra(baikiemtra.id_baikiemtra);
            existingBKT.bailam = baikiemtra.bailam;
            existingBKT.lich = baikiemtra.lich;
            existingBKT.ngaylambai = baikiemtra.ngaylambai;
            existingBKT.thoigian = baikiemtra.thoigian;
            existingBKT.tenmon = baikiemtra.tenmon;
            return existingBKT;
        }

        public BaiKiemTra GetBaiKiemTra(int id)
        {
            return bkts.SingleOrDefault(x => x.id_baikiemtra == id);
        }

        public List<BaiKiemTra> GetBaiKiemTras()
        {
            return bkts;
        }
    }
}
