using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public class LoaiTaiLieuRepository : ILoaiTaiLieucs
    {
        private List<LoaiTaiLieu> loaitailieus = new List<LoaiTaiLieu>();
        public LoaiTaiLieu AddLoaiTaiLieu(LoaiTaiLieu loaitailieu)
        {
            loaitailieu.id_loaitailieu = new LoaiTaiLieu().id_loaitailieu;
            loaitailieus.Add(loaitailieu);
            return loaitailieu;
        }

        public void DeleteLoaiTaiLieu(LoaiTaiLieu loaitailieu)
        {
            loaitailieus.Remove(loaitailieu);
        }

        public LoaiTaiLieu EditLoaiTaiLieu(LoaiTaiLieu loaitailieu)
        {

            var existingLoai = GetLoaiTaiLieu(loaitailieu.id_loaitailieu);
            existingLoai.tentailieu = loaitailieu.tentailieu;
            existingLoai.soluong = loaitailieu.soluong;
            return existingLoai;
        }

        public List<LoaiTaiLieu> GetLoaiTaiLieu()
        {
            return loaitailieus;
        }

        public LoaiTaiLieu GetLoaiTaiLieu(int id)
        {
            return loaitailieus.SingleOrDefault(x => x.id_loaitailieu == id);
        }
    }
}
