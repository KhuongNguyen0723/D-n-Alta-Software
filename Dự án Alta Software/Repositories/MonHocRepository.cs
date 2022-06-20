using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public class MonHocRepository : IMonHoc
    {
        private List<MonHoc> monhocs = new List<MonHoc>();
        public MonHoc AddMonHoc(MonHoc monhoc)
        {
            monhoc.id_monhoc = new MonHoc().id_monhoc;
            monhocs.Add(monhoc);
            return monhoc;
        }

        public void DeleteMonHoc(MonHoc monhoc)
        {
            monhocs.Remove(monhoc);
        }

        public MonHoc EditMonHoc(MonHoc monhoc)
        {
            var existingMonHoc = GetMonHoc(monhoc.id_monhoc);
            existingMonHoc.tenmonhoc = monhoc.tenmonhoc;
       
            return existingMonHoc;
        }

        public List<MonHoc> GetMonHoc()
        {
            return monhocs;
        }

        public MonHoc GetMonHoc(int id)
        {
            return monhocs.SingleOrDefault(x => x.id_monhoc == id);
        }
    }
}
