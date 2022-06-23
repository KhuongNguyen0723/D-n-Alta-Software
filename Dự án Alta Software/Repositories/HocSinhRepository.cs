using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public class HocSinhRepository : IHocSinh
    {
        private List<HocSinh> hocsinh = new List<HocSinh>();
        public HocSinh AddHocSinh(HocSinh hs)
        {
            hs.id_hocsinh = new HocSinh().id_hocsinh;
            hocsinh.Add(hs);
            return hs;
        }

        public void DeleteHocSinh(HocSinh hs)
        {
            hocsinh.Remove(hs);
        }

        public HocSinh EditHocSinh(HocSinh hs)
        {
            var hocsinh = GetHocSinh(hs.id_hocsinh);
            hocsinh.hoten = hs.hoten;
            hocsinh.diachi = hs.diachi;
            hocsinh.email = hs.email;
            hocsinh.namsinh = hs.namsinh;


            return hocsinh;
        }

        public HocSinh GetHocSinh(int id)
        {
            return hocsinh.SingleOrDefault(x => x.id_hocsinh == id);
        }

        public List<HocSinh> GetHocSinhs()
        {
            return hocsinh;
        }
    }
}
