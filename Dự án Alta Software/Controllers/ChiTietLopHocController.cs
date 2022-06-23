using Dự_án_Alta_Software.Model;
using Dự_án_Alta_Software.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dự_án_Alta_Software.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChiTietLopHocController : ControllerBase
    {
        private IChiTietLopHoc ctlhRepository;

        public ChiTietLopHocController(IChiTietLopHoc ctlhRepository)
        {
            this.ctlhRepository = ctlhRepository;
        }

        [HttpGet]
        //[Route("api/[controller]")]
        public IActionResult GetChiTietLopHoc()
        {
            return Ok(ctlhRepository.GetChiTietLopHocs());
        }

        [HttpGet("{id}")]
        //[Route("api/[controller]")]
        public IActionResult GetChiTietLopHoc(int id)
        {
            var ctlh = ctlhRepository.GetChiTietLopHoc(id);
            if (ctlh != null)
            {
                return Ok(ctlh);
            }
            return NotFound($"Lớp học không tồn tại");
        }

        [HttpPost]
        //[Route("api/[controller]")]
        public IActionResult GetChiTietLopHoc(ChiTietLopHoc ctlh)
        {
            ctlhRepository.AddChiTietLopHoc(ctlh);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + ctlh.id, ctlh);
        }

        [HttpDelete]
        //[Route("api/[controller]")]
        public IActionResult DeteleChiTietLopHoc(int id)
        {
            var ctlh = ctlhRepository.GetChiTietLopHoc(id);
            if (ctlh != null)
            {
                ctlhRepository.DeleteChiTietLopHoc(ctlh);
                return Ok();
            }
            return NotFound($"Lớp học không tồn tại");
        }

        [HttpPatch]
        //[Route("api/[controller]")]
        public IActionResult EditChiTietLopHoc(int id, ChiTietLopHoc ctlh)
        {
            var ctlhh = ctlhRepository.GetChiTietLopHoc(id);
            if (ctlhh != null)
            {
                ctlh.id = ctlhh.id;
                ctlhRepository.EditChiTietLopHoc(ctlh);
            }
            return Ok(ctlh);
        }
    }
}
