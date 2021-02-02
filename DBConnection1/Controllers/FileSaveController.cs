using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerSide.Controllers
{
    [ApiController]
    [Route("[controller]")]  //FileSave
    public class FileSaveController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileSaveController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost]
        public async Task<IActionResult> PostFile([FromForm] IFormFile file)
        {
            if (file == null) return new BadRequestResult();
            if (file.Length == 0) return new BadRequestResult();

            string path = @$"{_webHostEnvironment.WebRootPath}\Images\{file.FileName}";
     //       var physicalPath = Path.Combine("C:\\Users\\ludwi\\source\\repos\\Paranemi\\DBConnection1\\DBConnection1\\wwwroot\\Images", file.FileName);


            using MemoryStream ms = new();
            await file.CopyToAsync(ms);
            await System.IO.File.WriteAllBytesAsync(path, ms.ToArray());

            return new OkResult();

        }
    }
}
