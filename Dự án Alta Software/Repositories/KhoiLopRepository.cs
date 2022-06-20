using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public class KhoiLopRepository : IKhoiLop
    {
        private List<KhoiLop> khoilops = new List<KhoiLop>();
        public KhoiLop AddKhoiLop(KhoiLop khoilop)
        {
            khoilop.id_khoilop = new KhoiLop().id_khoilop;
            khoilops.Add(khoilop);
            return khoilop;
        }

        public void DeleteKhoiLop(KhoiLop khoilop)
        {
            khoilops.Remove(khoilop);
        }

        public KhoiLop EditKhoiLop(KhoiLop khoilop)
        {
            var existingKhoiLop = GetKhoiLop(khoilop.id_khoilop);
            existingKhoiLop.tenkhoi = khoilop.tenkhoi;

            return existingKhoiLop;
        }

        public KhoiLop GetKhoiLop(int id)
        {
            return khoilops.SingleOrDefault(x => x.id_khoilop == id);
        }

        public List<KhoiLop> GetKhoiLops()
        {
            return khoilops;
        }
    }
}
