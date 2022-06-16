using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public class PhanQuyenRepository : IPhanQuyen
    {
       

        private List<PhanQuyen> phanquyens = new List<PhanQuyen>();
        public PhanQuyen AddPhanQuyen(PhanQuyen phanquyen)
        {
            phanquyen.id_quyen = new PhanQuyen().id_quyen;
            phanquyens.Add(phanquyen);
            return phanquyen;
        }

        public void DeletePhanQuyen(PhanQuyen phanquyen)
        {
            phanquyens.Remove(phanquyen);
        }

        public PhanQuyen EditPhanQuyen(PhanQuyen phanquyen)
        {
            var existinPhanQuyen = GetPhanQuyen(phanquyen.id_quyen);
            existinPhanQuyen.tenquyen = phanquyen.tenquyen;
            return existinPhanQuyen;
        }

        public PhanQuyen GetPhanQuyen(int id)
        {
            return phanquyens.SingleOrDefault(x => x.id_quyen == id);
        }

        public List<PhanQuyen> GetPhanQuyens()
        {
            return phanquyens;
        }
    }
}
