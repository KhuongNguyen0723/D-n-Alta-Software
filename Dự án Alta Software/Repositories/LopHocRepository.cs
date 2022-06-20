using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public class LopHocRepository : ILopHoc
    {
        private List<LopHoc> lophocs = new List<LopHoc>();
        public LopHoc AddLopHoc(LopHoc lophoc)
        {
            lophoc.id_lophoc = new LopHoc().id_lophoc;
            lophocs.Add(lophoc);
            return lophoc;
        }

        public void DeleteLopHoc(LopHoc lophoc)
        {
            lophocs.Remove(lophoc);
        }

        public LopHoc EditLopHoc(LopHoc lophoc)
        {
            var existingLopHoc = GetLopHoc(lophoc.id_lophoc);
            existingLopHoc.tenlophoc = lophoc.tenlophoc;
            existingLopHoc.chude = lophoc.chude;
            existingLopHoc.monhoc = lophoc.monhoc;
            return existingLopHoc;
        }

        public LopHoc GetLopHoc(int id)
        {
            return lophocs.SingleOrDefault(x => x.id_lophoc == id);
        }

        public List<LopHoc> GetLopHocs()
        {
            return lophocs;
        }
    }
}
