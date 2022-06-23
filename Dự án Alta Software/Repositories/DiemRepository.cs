using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public class DiemRepository : IDiem
    {
        private List<Diem> diems = new List<Diem>();
        public Diem AddDiem(Diem diem)
        {
            diem.id_diem = new Diem().id_diem;
            diems.Add(diem);
            return diem;
        }

        public void DeleteDiem(Diem diem)
        {
            diems.Remove(diem);
        }

        public Diem EditDiem(Diem diem)
        {
            var Diemss = GetDiem(diem.id_diem);
            Diemss.kiemtramieng = diem.kiemtramieng;
            Diemss.diemtrungbinh = diem.diemtrungbinh;
            Diemss.diemchuyencan = diem.diemchuyencan;
            Diemss.danhgia = diem.danhgia;
            Diemss.heso2 = diem.heso2;
            Diemss.heso3 = diem.heso3;
            Diemss.diemtongket = diem.diemtongket;


            return Diemss;
        }

        public Diem GetDiem(int id)
        {
            return diems.SingleOrDefault(x => x.id_diem == id);
        }

        public List<Diem> GetDiems()
        {
            return diems;
        }
    }
}
