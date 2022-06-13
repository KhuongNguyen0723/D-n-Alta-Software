using Dự_án_Alta_Software.Model;
using Dự_án_Alta_Software.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dự_án_Alta_Software.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private ITaiKhoanRepository taiKhoanRepository;

        public AccountController(ITaiKhoanRepository taiKhoanRepository)
        {
            this.taiKhoanRepository = taiKhoanRepository;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetTaiKhoan()
        {
            return Ok(taiKhoanRepository.GetTaiKhoans());
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetTaiKhoan(int id)
        {
            var taikhoan = taiKhoanRepository.GetTaiKhoan(id);
            if(taikhoan != null)
            {
                return Ok(taikhoan);
            }
            return NotFound($"Tài khoản không tồn tại");
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult GetTaiKhoan(TaiKhoan taiKhoan)
        {
            taiKhoanRepository.AddTaiKhoan(taiKhoan);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + taiKhoan.id_taikhoan, taiKhoan);
        }

        [HttpDelete]
        [Route("api/[controller]")]
        public IActionResult DeteleTaiKhoan(int id)
        {
            var taikhoan = taiKhoanRepository.GetTaiKhoan(id);
            if(taikhoan != null)
            {
                taiKhoanRepository.DeleteTaiKhoan(taikhoan);
                return Ok();
            }
            return NotFound($"Tài khoản không tồn tại");
        }

        [HttpPatch]
        [Route("api/[controller]")]
        public IActionResult EditTaiKhoan(int id,TaiKhoan taiKhoan)
        {
            var existingTaiKhoan = taiKhoanRepository.GetTaiKhoan(id);
            if(existingTaiKhoan != null)
            {
                taiKhoan.id_taikhoan = existingTaiKhoan.id_taikhoan;
                taiKhoanRepository.EditTaiKhoan(taiKhoan);
            }
            return Ok(taiKhoan);
        }
    }
}
