using Dự_án_Alta_Software.Model;
using Dự_án_Alta_Software.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dự_án_Alta_Software.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LopHocController : ControllerBase
    {
        private ILopHoc lophocRepository;

        public LopHocController(ILopHoc lophocRepository)
        {
            this.lophocRepository = lophocRepository;
        }

        [HttpGet]
        //[Route("api/[controller]")]
        public IActionResult GetLopHoc()
        {
            return Ok(lophocRepository.GetLopHocs());
        }

        [HttpGet("{id}")]
        //[Route("api/[controller]")]
        public IActionResult GetLopHoc(int id)
        {
            var lophoc = lophocRepository.GetLopHoc(id);
            if (lophoc != null)
            {
                return Ok(lophoc);
            }
            return NotFound($"Lớp học không tồn tại");
        }

        [HttpPost]
        //[Route("api/[controller]")]
        public IActionResult GetLopHoc(LopHoc lophoc)
        {
            lophocRepository.AddLopHoc(lophoc);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + lophoc.id_lophoc, lophoc);
        }

        [HttpDelete]
        //[Route("api/[controller]")]
        public IActionResult DeteleLopHoc(int id)
        {
            var lophoc = lophocRepository.GetLopHoc(id);
            if (lophoc != null)
            {
                lophocRepository.DeleteLopHoc(lophoc);
                return Ok();
            }
            return NotFound($"Lớp học không tồn tại");
        }

        [HttpPatch]
        //[Route("api/[controller]")]
        public IActionResult EditLopHoc(int id, LopHoc lophoc)
        {
            var existingLop = lophocRepository.GetLopHoc(id);
            if (existingLop != null)
            {
                lophoc.id_lophoc = existingLop.id_lophoc;
                lophocRepository.EditLopHoc(lophoc);
            }
            return Ok(lophoc);
        }
    }
}
