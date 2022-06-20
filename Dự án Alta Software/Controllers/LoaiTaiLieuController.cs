using Dự_án_Alta_Software.Model;
using Dự_án_Alta_Software.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dự_án_Alta_Software.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiTaiLieuController : ControllerBase
    {
        private ILoaiTaiLieucs loaitailieuRepository;

        public LoaiTaiLieuController(ILoaiTaiLieucs loaitailieuRepository)
        {
            this.loaitailieuRepository = loaitailieuRepository;
        }

        [HttpGet]
        //[Route("api/[controller]")]
        public IActionResult GetLoaiTaiLieu()
        {
            return Ok(loaitailieuRepository.GetLoaiTaiLieu());
        }

        [HttpGet("{id}")]
        //[Route("api/[controller]")]
        public IActionResult GetLoaiTaiLieu(int id)
        {
            var loai = loaitailieuRepository.GetLoaiTaiLieu(id);
            if (loai != null)
            {
                return Ok(loai);
            }
            return NotFound($"Loại tài liệu không tồn tại");
        }

        [HttpPost]
        //[Route("api/[controller]")]
        public IActionResult GetLoaiTaiLieu(LoaiTaiLieu loaitailieu)
        {
            loaitailieuRepository.AddLoaiTaiLieu(loaitailieu);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + loaitailieu.id_loaitailieu, loaitailieu);
        }

        [HttpDelete]
        //[Route("api/[controller]")]
        public IActionResult DeteleLoaiTaiLieu(int id)
        {
            var loai = loaitailieuRepository.GetLoaiTaiLieu(id);
            if (loai != null)
            {
                loaitailieuRepository.DeleteLoaiTaiLieu(loai);
                return Ok();
            }
            return NotFound($"Loại tài liệun không tồn tại");
        }

        [HttpPatch]
        //[Route("api/[controller]")]
        public IActionResult EditTaiKhoan(int id, LoaiTaiLieu loai)
        {
            var existingLoai = loaitailieuRepository.GetLoaiTaiLieu(id);
            if (existingLoai != null)
            {
                loai.id_loaitailieu = existingLoai.id_loaitailieu;
                loaitailieuRepository.EditLoaiTaiLieu(loai);
            }
            return Ok(loai);
        }
    }
}

