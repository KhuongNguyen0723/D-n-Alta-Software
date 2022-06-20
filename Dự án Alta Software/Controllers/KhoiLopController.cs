using Dự_án_Alta_Software.Model;
using Dự_án_Alta_Software.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dự_án_Alta_Software.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhoiLopController : ControllerBase
    {
        private IKhoiLop khoilopRepository;

        public KhoiLopController(IKhoiLop khoilopRepository)
        {
            this.khoilopRepository = khoilopRepository;
        }

        [HttpGet]
        //[Route("api/[controller]")]
        public IActionResult GetKhoiLop()
        {
            return Ok(khoilopRepository.GetKhoiLops());
        }

        [HttpGet("{id}")]
        //[Route("api/[controller]")]
        public IActionResult GetKhoiLop(int id)
        {
            var khoilop = khoilopRepository.GetKhoiLop(id);
            if (khoilop != null)
            {
                return Ok(khoilop);
            }
            return NotFound($"Khối lớp không tồn tại");
        }

        [HttpPost]
        //[Route("api/[controller]")]
        public IActionResult GetKhoiLop(KhoiLop khoilop)
        {
            khoilopRepository.AddKhoiLop(khoilop);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + khoilop.id_khoilop, khoilop);
        }

        [HttpDelete]
        //[Route("api/[controller]")]
        public IActionResult DeteleKhoiLop(int id)
        {
            var khoilop = khoilopRepository.GetKhoiLop(id);
            if (khoilop != null)
            {
                khoilopRepository.DeleteKhoiLop(khoilop);
                return Ok();
            }
            return NotFound($"Khối lớp không tồn tại");
        }

        [HttpPatch]
        //[Route("api/[controller]")]
        public IActionResult EditKhoiLop(int id, KhoiLop khoilop)
        {
            var existingKhoiLop = khoilopRepository.GetKhoiLop(id);
            if (existingKhoiLop != null)
            {
                khoilop.id_khoilop = existingKhoiLop.id_khoilop;
                khoilopRepository.EditKhoiLop(khoilop);
            }
            return Ok(khoilop);
        }
    }
}
