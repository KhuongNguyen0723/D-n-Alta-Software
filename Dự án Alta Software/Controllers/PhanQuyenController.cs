using Dự_án_Alta_Software.Model;
using Dự_án_Alta_Software.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dự_án_Alta_Software.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhanQuyenController : ControllerBase
    {
        private IPhanQuyen phanquyenRepository;

        public PhanQuyenController(IPhanQuyen phanquyenRepository)
        {
            this.phanquyenRepository = phanquyenRepository;
        }

        [HttpGet]
        //[Route("api/[controller]")]
        public IActionResult GetPhanQuyen()
        {
            return Ok(phanquyenRepository.GetPhanQuyens());
        }

        [HttpGet("id")]
        //[Route("api/[controller]")]
        public IActionResult GetPhanQuyen(int id)
        {
            var phanquyen = phanquyenRepository.GetPhanQuyen(id);
            if (phanquyen != null)
          {
                return Ok(phanquyen);
            }
            return NotFound();
        }

        [HttpPost]
        //[Route("api/[controller]")]
        public IActionResult GetPhanQuyen(PhanQuyen phanquyen)
        {
            phanquyenRepository.AddPhanQuyen(phanquyen);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + phanquyen.id_quyen, phanquyen);
        }

        [HttpDelete]
        //[Route("api/[controller]")]
        public IActionResult DetelePhanQuyen(int id)
        {
            var phanquyen = phanquyenRepository.GetPhanQuyen(id);
            if (phanquyen != null)
            {
                phanquyenRepository.DeletePhanQuyen(phanquyen);
                return Ok();
           }
           return NotFound();
        }

        [HttpPatch]
        //[Route("api/[controller]")]
        public IActionResult EditPhanQuyen(int id, PhanQuyen phanquyen)
        {
            var existingPhanQuyen = phanquyenRepository.GetPhanQuyen(id);
           if (existingPhanQuyen != null)
            {
                phanquyen.id_quyen = existingPhanQuyen.id_quyen;
                phanquyenRepository.EditPhanQuyen(phanquyen);
           }
            return Ok(phanquyen);
        }
    }
}

