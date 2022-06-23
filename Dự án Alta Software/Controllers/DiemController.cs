using Dự_án_Alta_Software.Model;
using Dự_án_Alta_Software.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dự_án_Alta_Software.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiemController : ControllerBase
    {
        private IDiem diemRepository;

        public DiemController(IDiem diemRepository)
        {
            this.diemRepository = diemRepository;
        }

        [HttpGet]
        //[Route("api/[controller]")]
        public IActionResult GetDiem()
        {
            return Ok(diemRepository.GetDiems());
        }

        [HttpGet("{id}")]
        //[Route("api/[controller]")]
        public IActionResult GetDiem(int id)
        {
            var diem = diemRepository.GetDiem(id);
            if (diem != null)
            {
                return Ok(diem);
            }
            return NotFound($"Bài kiểm tra không tồn tại");
        }

        [HttpPost]
        //[Route("api/[controller]")]
        public IActionResult GetDiem(Diem diem)
        {
            diemRepository.AddDiem(diem);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + diem.id_diem, diem);
        }

        [HttpDelete]
        //[Route("api/[controller]")]
        public IActionResult DeteleBaiKiemTra(int id)
        {
            var diem = diemRepository.GetDiem(id);
            if (diem != null)
            {
                diemRepository.DeleteDiem(diem);
                return Ok();
            }
            return NotFound($"Bài kiểm tra không tồn tại");
        }

        [HttpPatch]
        //[Route("api/[controller]")]
        public IActionResult EditDiem(int id, Diem diems)
        {
            var diem = diemRepository.GetDiem(id);
            if (diem != null)
            {
                diems.id_diem = diem.id_diem;
                diemRepository.EditDiem(diems);
            }
            return Ok(diems);
        }
    }
}
