using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public class KhoaHocRepository : IKhoaHoc
    {
        private List<KhoaHoc> khoahoc = new List<KhoaHoc>();
        public KhoaHoc AddKhoaHoc(KhoaHoc kh)
        {
            kh.id_khoahoc = new KhoaHoc().id_khoahoc;
            khoahoc.Add(kh);
            return kh;
        }

        public void DeleteKhoaHoc(KhoaHoc kh)
        {
            khoahoc.Remove(kh);
        }

        public KhoaHoc EditKhoaHoc(KhoaHoc kh)
        {
            var khoahoc = GetKhoaHoc(kh.id_khoahoc);
            khoahoc.tenkhoahoc = kh.tenkhoahoc;
            khoahoc.hocky = kh.hocky;

            return khoahoc;
        }

        public KhoaHoc GetKhoaHoc(int id)
        {
            return khoahoc.SingleOrDefault(x => x.id_khoahoc == id);
        }

        public List<KhoaHoc> GetKhoaHocs()
        {
            return khoahoc;
        }
    }
}
