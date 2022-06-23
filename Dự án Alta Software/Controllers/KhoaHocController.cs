using Dự_án_Alta_Software.Model;
using Dự_án_Alta_Software.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dự_án_Alta_Software.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhoaHocController : ControllerBase
    {
        private IKhoaHoc khRepository;

        public KhoaHocController(IKhoaHoc khRepository)
        {
            this.khRepository = khRepository;
        }

        [HttpGet]
        //[Route("api/[controller]")]
        public IActionResult GetKhoaHoc()
        {
            return Ok(khRepository.GetKhoaHocs());
        }

        [HttpGet("{id}")]
        //[Route("api/[controller]")]
        public IActionResult GetKhoaHoc(int id)
        {
            var kh = khRepository.GetKhoaHoc(id);
            if (kh != null)
            {
                return Ok(kh);
            }
            return NotFound($"Khóa học không tồn tại");
        }

        [HttpPost]
        //[Route("api/[controller]")]
        public IActionResult GetKhoaHoc(KhoaHoc kh)
        {
            khRepository.AddKhoaHoc(kh);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + kh.id_khoahoc, kh);
        }

        [HttpDelete]
        //[Route("api/[controller]")]
        public IActionResult DeteleKhoaHoc(int id)
        {
            var kh = khRepository.GetKhoaHoc(id);
            if (kh != null)
            {
                khRepository.DeleteKhoaHoc(kh);
                return Ok();
            }
            return NotFound($"Khóa học không tồn tại");
        }

        [HttpPatch]
        //[Route("api/[controller]")]
        public IActionResult EditKhoaHoc(int id, KhoaHoc kh)
        {
            var khoahoc = khRepository.GetKhoaHoc(id);
            if (khoahoc != null)
            {
                kh.id_khoahoc = khoahoc.id_khoahoc;
                khRepository.EditKhoaHoc(kh);
            }
            return Ok(kh);
        }
    }
}
