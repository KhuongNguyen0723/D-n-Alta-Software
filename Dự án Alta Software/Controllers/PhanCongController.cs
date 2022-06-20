using Dự_án_Alta_Software.Model;
using Dự_án_Alta_Software.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dự_án_Alta_Software.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhanCongController : ControllerBase
    {
        private IPhanCong phancongRepository;

        public PhanCongController(IPhanCong phancongRepository)
        {
            this.phancongRepository = phancongRepository;
        }

        [HttpGet]
        //[Route("api/[controller]")]
        public IActionResult GetPhanCong()
        {
            return Ok(phancongRepository.GetPhanCong());
        }

        [HttpGet("{id}")]
        //[Route("api/[controller]")]
        public IActionResult GetPhanCong(int id)
        {
            var loai = phancongRepository.GetPhanCong(id);
            if (loai != null)
            {
                return Ok(loai);
            }
            return NotFound($"Không tìm thấy");
        }

        [HttpPost]
        //[Route("api/[controller]")]
        public IActionResult GetPhanCong(PhanCong phancong)
        {
            phancongRepository.AddPhanCong(phancong);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + phancong.id_phancong, phancong);
        }

        [HttpDelete]
        //[Route("api/[controller]")]
        public IActionResult DetelePhanCong(int id)
        {
            var phancong = phancongRepository.GetPhanCong(id);
            if (phancong != null)
            {
                phancongRepository.DeletePhanCong(phancong);
                return Ok();
            }
            return NotFound($"Không tìm thấy");
        }

        [HttpPatch]
        //[Route("api/[controller]")]
        public IActionResult EditPhanCong(int id, PhanCong phancong)
        {
            var existingPhanCong = phancongRepository.GetPhanCong(id);
            if (existingPhanCong != null)
            {
                phancong.id_phancong = existingPhanCong.id_phancong;
                phancongRepository.EditPhanCong(phancong);
            }
            return Ok(phancong);
        }
    }
}

