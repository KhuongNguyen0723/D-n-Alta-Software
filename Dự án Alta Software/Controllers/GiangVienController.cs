using Dự_án_Alta_Software.Model;
using Dự_án_Alta_Software.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dự_án_Alta_Software.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiangVienController : ControllerBase
    {
        private IGiangVien gvRepository;

        public GiangVienController(IGiangVien gvRepository)
        {
            this.gvRepository = gvRepository;
        }

        [HttpGet]
        //[Route("api/[controller]")]
        public IActionResult GetGiangVien()
        {
            return Ok(gvRepository.GetGiangViens());
        }

        [HttpGet("{id}")]
        //[Route("api/[controller]")]
        public IActionResult GetGiangVien(int id)
        {
            var gv = gvRepository.GetGiangVien(id);
            if (gv != null)
            {
                return Ok(gv);
            }
            return NotFound($"Giảng viên không tìm thấy");
        }

        [HttpPost]
        //[Route("api/[controller]")]
        public IActionResult GetGiangVien(GiangVien gv)
        {
            gvRepository.AddGiangVien(gv);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + gv.id_giangvien, gv);
        }

        [HttpDelete]
        //[Route("api/[controller]")]
        public IActionResult DeleteGiangVien(int id)
        {
            var gv = gvRepository.GetGiangVien(id);
            if (gv != null)
            {
                gvRepository.DeleteGiangVien(gv);
                return Ok();
            }
            return NotFound($"Giảng viên không tìm thấy");
        }

        [HttpPatch]
        //[Route("api/[controller]")]
        public IActionResult EditGiangVien(int id, GiangVien gv)
        {
            var gvs = gvRepository.GetGiangVien(id);
            if (gvs != null)
            {
                gv.id_giangvien = gvs.id_giangvien;
                gvRepository.EditGiangVien(gv);
            }
            return Ok(gv);
        }
    }
}
