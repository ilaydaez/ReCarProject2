using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class ImagesController : ControllerBase
    {
        IImageService _ımageService;
        IWebHostEnvironment _webHostEnvironment;

        public ImagesController(IImageService ımageService, IWebHostEnvironment webHostEnvironment)
        {
            _ımageService = ımageService;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] Image image)
        {
            string path = _webHostEnvironment.WebRootPath + "\\Images\\";
            var newGuidPath = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            using (FileStream fileStream = System.IO.File.Create(path + newGuidPath))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
            if (file == null)
            {
                image.ImagePath = path + "default.png";
            }

            var result = _ımageService.Add(new Image
            {
                CarID = image.CarID,
                Date = DateTime.Now,
                ImagePath = newGuidPath
            });

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("DeleteImage")]
        public IActionResult DeleteImage(Image ımage)
        {
            var result = _ımageService.Delete(ımage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("UpDateImage")]
        public IActionResult UpDateImage(Image ımage)
        {
            var result = _ımageService.UpDate(ımage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _ımageService.GetByImages();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetByImageID")]
        public IActionResult GetByImageID(int ımageID)
        {
            var result = _ımageService.GetByImageID(ımageID);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetImageByCarID")]
        public IActionResult GetImageByCarID(int carId)
        {
            var result = _ımageService.GetImageByCarID(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetImageByDate")]
        public IActionResult GetImageByDate(DateTime ımageDate)
        {
            var result = _ımageService.GetImageByDate(ımageDate);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
