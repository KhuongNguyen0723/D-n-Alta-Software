using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public class TaiLieuRepository : ITaiLieu
    {
        private List<TaiLieu> tailieu = new List<TaiLieu>();
        public TaiLieu AddTaiLieu(TaiLieu tailieus)
        {
            tailieus.id_tailieu = new TaiLieu().id_tailieu;
            tailieu.Add(tailieus);
            return tailieus;
        }

        public void DeleteTaiLieu(TaiLieu tailieus)
        {
           tailieu.Remove(tailieus);
        }

        public TaiLieu EditTaiLieu(TaiLieu tailieus)
        {
            var existingTaiLieu = GetTaiLieu(tailieus.id_tailieu);
            existingTaiLieu.tentailieu = tailieus.tentailieu;
            return existingTaiLieu;
        }

        public TaiLieu GetTaiLieu(int id)
        {
            return tailieu.SingleOrDefault(x => x.id_tailieu == id);
        }

        public List<TaiLieu> GetTaiLieu()
        {
            return tailieu;
        }
    }
}
