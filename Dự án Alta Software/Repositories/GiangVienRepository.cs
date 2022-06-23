using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public class GiangVienRepository : IGiangVien
    {
        private List<GiangVien> gvs = new List<GiangVien>();
        public GiangVien AddGiangVien(GiangVien gv)
        {
            gv.id_giangvien = new GiangVien().id_giangvien;
            gvs.Add(gv);
            return gv;
        }

        public void DeleteGiangVien(GiangVien gv)
        {

            gvs.Remove(gv);
        }

        public GiangVien EditGiangVien(GiangVien gv)
        {
            var Giangviens = GetGiangVien(gv.id_giangvien);
            Giangviens.tengiangvien = gv.tengiangvien;
            Giangviens.email = gv.email;
            Giangviens.sdt = gv.sdt;
           


            return Giangviens;
        }

        public GiangVien GetGiangVien(int id)
        {
            return gvs.SingleOrDefault(x => x.id_giangvien == id);
        }

        public List<GiangVien> GetGiangViens()
        {
            return gvs;
        }
    }
}
