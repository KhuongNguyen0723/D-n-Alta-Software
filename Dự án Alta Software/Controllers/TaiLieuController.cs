using Dự_án_Alta_Software.Model;
using Dự_án_Alta_Software.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dự_án_Alta_Software.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaiLieuController : ControllerBase
    {
        private ITaiLieu tailieuRepository;

        public TaiLieuController(ITaiLieu tailieuRepository)
        {
            this.tailieuRepository = tailieuRepository;
        }

        [HttpGet]
        //[Route("api/[controller]")]
       public IActionResult GetTaiLieu()
        {
            return Ok(tailieuRepository.GetTaiLieu());
        }

        [HttpGet("id")]
        //[Route("api/[controller]")]
        public IActionResult GetTaiLieu(int id)
        {
            var tailieu = tailieuRepository.GetTaiLieu(id);
            if (tailieu != null)
            {
                return Ok(tailieu);
            }
            return NotFound($"Tài liệu không tìm thấy");
        }

        [HttpPost]
        //[Route("api/[controller]")]
        public IActionResult GetTaiLieu(TaiLieu tailieu)
        {
            tailieuRepository.AddTaiLieu(tailieu);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + tailieu.id_tailieu, tailieu);
        }

        [HttpDelete]
        //[Route("api/[controller]")]
        public IActionResult DeteleTaiLieu(int id)
        {
           var tailieu = tailieuRepository.GetTaiLieu(id);
            if (tailieu != null)
            {
                tailieuRepository.DeleteTaiLieu(tailieu);
               return Ok();
            }
            return NotFound($"Tài liệu không tìm thấy");
        }

        [HttpPatch]
        //[Route("api/[controller]")]
        public IActionResult EditTaiKhoan(int id, TaiLieu tailieu)
        {
            var existingTaiLieu = tailieuRepository.GetTaiLieu(id);
            if (existingTaiLieu != null)
            {
                tailieu.id_tailieu = existingTaiLieu.id_tailieu;
                tailieuRepository.EditTaiLieu(tailieu);
            }
           return Ok(tailieu);
        }
    }
}

