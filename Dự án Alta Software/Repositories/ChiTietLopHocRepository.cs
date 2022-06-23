using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public class ChiTietLopHocRepository : IChiTietLopHoc
    {
        private List<ChiTietLopHoc> ctlhs = new List<ChiTietLopHoc>();
        public ChiTietLopHoc AddChiTietLopHoc(ChiTietLopHoc ctlh)
        {
            ctlh.LopHoc = new ChiTietLopHoc().LopHoc;
            ctlhs.Add(ctlh);
            return ctlh;
        }

        public void DeleteChiTietLopHoc(ChiTietLopHoc ctlh)
        {
            ctlhs.Remove(ctlh);
        }

        public ChiTietLopHoc EditChiTietLopHoc(ChiTietLopHoc ctlh)
        {
            var existingCTLH = GetChiTietLopHoc(ctlh.id);
            existingCTLH.lopsapmo = ctlh.lopsapmo;
            existingCTLH.lopchuahoanthanh = ctlh.lopchuahoanthanh;
            existingCTLH.lopdahoanthanh = ctlh.lopdahoanthanh;
           
            return existingCTLH;
        }

        public ChiTietLopHoc GetChiTietLopHoc(int id)
        {
            return ctlhs.SingleOrDefault(x => x.id == id);
        }

        public List<ChiTietLopHoc> GetChiTietLopHocs()
        {
            return ctlhs;
        }
    }
}
