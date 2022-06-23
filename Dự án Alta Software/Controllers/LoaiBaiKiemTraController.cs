using Dự_án_Alta_Software.Model;
using Dự_án_Alta_Software.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dự_án_Alta_Software.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiBaiKiemTraController : ControllerBase
    {
        private ILoaiBaiKiemTra lbktRepository;

        public LoaiBaiKiemTraController(ILoaiBaiKiemTra lbktRepository)
        {
            this.lbktRepository = lbktRepository;
        }

        [HttpGet]
        //[Route("api/[controller]")]
        public IActionResult GetLoaiBaiKiemTra()
        {
            return Ok(lbktRepository.GetLoaiBaiKiemTras());
        }

        [HttpGet("{id}")]
        //[Route("api/[controller]")]
        public IActionResult GetLoaiBaiKiemTra(int id)
        {
            var lbkt = lbktRepository.GetLoaiBaiKiemTra(id);
            if (lbkt != null)
            {
                return Ok(lbkt);
            }
            return NotFound($"Bài kiểm tra không tồn tại");
        }

        [HttpPost]
        //[Route("api/[controller]")]
        public IActionResult GetLoaiBaiKiemTra(LoaiBaiKiemTra lbkt)
        {
            lbktRepository.AddLoaiBaiKiemTra(lbkt);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + lbkt.id_loaibaikiemtra, lbkt);
        }

        [HttpDelete]
        //[Route("api/[controller]")]
        public IActionResult DeteleLoaiKiemTra(int id)
        {
            var lbkt = lbktRepository.GetLoaiBaiKiemTra(id);
            if (lbkt != null)
            {
                lbktRepository.DeleteLoaiBaiKiemTra(lbkt);
                return Ok();
            }
            return NotFound($"Bài kiểm tra không tồn tại");
        }

        [HttpPatch]
        //[Route("api/[controller]")]
        public IActionResult EditLoaiKiemTra(int id, LoaiBaiKiemTra lbkt)
        {
            var loai = lbktRepository.GetLoaiBaiKiemTra(id);
            if (loai != null)
            {
                lbkt.id_loaibaikiemtra = loai.id_loaibaikiemtra;
                lbktRepository.EditLoaiBaiKiemTra(lbkt);
            }
            return Ok(lbkt);
        }
    }
}
