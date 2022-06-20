using Dự_án_Alta_Software.Model;
using Dự_án_Alta_Software.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dự_án_Alta_Software.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonHocController : ControllerBase
    {
        private IMonHoc monhocRepository;

        public MonHocController(IMonHoc monhocRepository)
        {
            this.monhocRepository = monhocRepository;
        }

        [HttpGet]
        //[Route("api/[controller]")]
        public IActionResult GetMonHoc()
        {
            return Ok(monhocRepository.GetMonHoc());
        }

        [HttpGet("{id}")]
        //[Route("api/[controller]")]
        public IActionResult GetMonHoc(int id)
        {
            var loai = monhocRepository.GetMonHoc(id);
            if (loai != null)
            {
                return Ok(loai);
            }
            return NotFound($"Môn học không tồn tại");
        }

        [HttpPost]
        //[Route("api/[controller]")]
        public IActionResult GetMonHoc(MonHoc momhoc)
        {
            monhocRepository.AddMonHoc(momhoc);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + momhoc.id_monhoc, momhoc);
        }

        [HttpDelete]
        //[Route("api/[controller]")]
        public IActionResult DeteleMonHoc(int id)
        {
            var monhoc = monhocRepository.GetMonHoc(id);
            if (monhoc != null)
            {
                monhocRepository.DeleteMonHoc(monhoc);
                return Ok();
            }
            return NotFound($"Môn học không tồn tại");
        }

        [HttpPatch]
        //[Route("api/[controller]")]
        public IActionResult EditMonHoc(int id, MonHoc monhoc)
        {
            var existingMonHoc = monhocRepository.GetMonHoc(id);
            if (existingMonHoc != null)
            {
                monhoc.id_monhoc = existingMonHoc.id_monhoc;
                monhocRepository.EditMonHoc(monhoc);
            }
            return Ok(monhoc);
        }
    }
}

