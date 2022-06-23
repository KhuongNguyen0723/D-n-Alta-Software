using Dự_án_Alta_Software.Model;
using Dự_án_Alta_Software.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dự_án_Alta_Software.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HocSinhController : ControllerBase
    {
        private IHocSinh hsRepository;

        public HocSinhController(IHocSinh hsRepository)
        {
            this.hsRepository = hsRepository;
        }

        [HttpGet]
        //[Route("api/[controller]")]
        public IActionResult GetHocSinh()
        {
            return Ok(hsRepository.GetHocSinhs());
        }

        [HttpGet("{id}")]
        //[Route("api/[controller]")]
        public IActionResult GetHocSinh(int id)
        {
            var gv = hsRepository.GetHocSinh(id);
            if (gv != null)
            {
                return Ok(gv);
            }
            return NotFound($"Học sinh không tìm thấy");
        }

        [HttpPost]
        //[Route("api/[controller]")]
        public IActionResult GetHocSinh(HocSinh hs)
        {
            hsRepository.AddHocSinh(hs);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + hs.id_hocsinh, hs);
        }

        [HttpDelete]
        //[Route("api/[controller]")]
        public IActionResult DeleteHocSinh(int id)
        {
            var hs = hsRepository.GetHocSinh(id);
            if (hs != null)
            {
                hsRepository.DeleteHocSinh(hs);
                return Ok();
            }
            return NotFound($"Học sinh không tìm thấy");
        }

        [HttpPatch]
        //[Route("api/[controller]")]
        public IActionResult EditHocSinh(int id, HocSinh hs)
        {
            var hocsinh = hsRepository.GetHocSinh(id);
            if (hocsinh != null)
            {
                hs.id_hocsinh = hocsinh.id_hocsinh;
                hsRepository.EditHocSinh(hs);
            }
            return Ok(hs);
        }
    }
}
