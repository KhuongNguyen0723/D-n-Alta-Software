using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public class PhanCongRepository : IPhanCong
    {
        private List<PhanCong> phancongs = new List<PhanCong>();
        public PhanCong AddPhanCong(PhanCong phancong)
        {
            phancong.id_phancong = new PhanCong().id_phancong;
            phancongs.Add(phancong);
            return phancong;
        }

        public void DeletePhanCong(PhanCong phancong)
        {
            phancongs.Remove(phancong);
        }

        public PhanCong EditPhanCong(PhanCong phancong)
        {
            var existingPhanCong = GetPhanCong(phancong.id_phancong);
            existingPhanCong.tenbang = phancong.tenbang;
            existingPhanCong.thoigian = phancong.thoigian;
           


            return existingPhanCong;
        }

        public List<PhanCong> GetPhanCong()
        {
            return phancongs;
        }

        public PhanCong GetPhanCong(int id)
        {
            return phancongs.SingleOrDefault(x => x.id_phancong == id);
        }
    }
}
