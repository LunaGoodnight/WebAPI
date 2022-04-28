using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Model;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ImageServerController : ControllerBase
{


    [HttpGet("GetImageList")]
    public List<ImageServerInfo> GetImageList()
    {
        
        var imageServerInfoList = new ImageServerInfo[]
        {
            new ImageServerInfo{ Cn = true, Remark = "test" },
            new ImageServerInfo{ Cn = false, Remark = "miou" },
        };

        return imageServerInfoList.ToList();
    }
}