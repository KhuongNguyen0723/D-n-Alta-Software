using Dự_án_Alta_Software.Model;

namespace Dự_án_Alta_Software.Repositories
{
    public interface IDiem
    {
        List<Diem> GetDiems();

        Diem GetDiem(int id);
        Diem AddDiem(Diem diem);

        void DeleteDiem(Diem diem);

        Diem EditDiem(Diem diem);
    }
}
