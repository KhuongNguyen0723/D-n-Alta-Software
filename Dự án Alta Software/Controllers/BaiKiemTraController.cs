using Dự_án_Alta_Software.Model;
using Dự_án_Alta_Software.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dự_án_Alta_Software.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaiKiemTraController : ControllerBase
    {
        private IBaiKiemTra btkRepository;

        public BaiKiemTraController(IBaiKiemTra btkRepository)
        {
            this.btkRepository = btkRepository;
        }

        [HttpGet]
        //[Route("api/[controller]")]
        public IActionResult GetBaiKiemTra()
        {
            return Ok(btkRepository.GetBaiKiemTras());
        }

        [HttpGet("{id}")]
        //[Route("api/[controller]")]
        public IActionResult GetBaiKiemTra(int id)
        {
            var khoilop = btkRepository.GetBaiKiemTra(id);
            if (khoilop != null)
            {
                return Ok(khoilop);
            }
            return NotFound($"Bài kiểm tra không tồn tại");
        }

        [HttpPost]
        //[Route("api/[controller]")]
        public IActionResult GetBaiKiemTra(BaiKiemTra btk)
        {
            btkRepository.AddBaiKiemTra(btk);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + btk.id_baikiemtra, btk);
        }

        [HttpDelete]
        //[Route("api/[controller]")]
        public IActionResult DeteleBaiKiemTra(int id)
        {
            var bkt = btkRepository.GetBaiKiemTra(id);
            if (bkt != null)
            {
                btkRepository.DeleteBaiKiemTra(bkt);
                return Ok();
            }
            return NotFound($"Bài kiểm tra không tồn tại");
        }

        [HttpPatch]
        //[Route("api/[controller]")]
        public IActionResult EditKhoiLop(int id, BaiKiemTra bkt)
        {
            var existingBKT = btkRepository.GetBaiKiemTra(id);
            if (existingBKT != null)
            {
                bkt.id_baikiemtra = existingBKT.id_baikiemtra;
                btkRepository.EditBaiKiemTra(bkt);
            }
            return Ok(bkt);
        }
    }
}
