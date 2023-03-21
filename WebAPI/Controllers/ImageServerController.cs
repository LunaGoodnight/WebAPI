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
            new ImageServerInfo{ Cn = true, Remark = "test", Domain = "www.cookiesbydesign.com", isDefault = false},
            new ImageServerInfo{ Cn = true, Remark = "gourmet", Domain = "www.cuteLuna.com", isDefault = true},
            new ImageServerInfo{ Cn = false, Remark = "miou", Domain = "www.yahoo.com", isDefault = true },
            new ImageServerInfo{ Cn = false, Remark = "emoji", Domain = "www.google.com", isDefault = false },
            new ImageServerInfo{ Cn = false, Remark = "delectable", Domain = "www.microsoft.com", isDefault = false },
        };

        return imageServerInfoList.ToList();
    }
    
    

    [HttpGet("UpdateImageDomain")]
    public ActionResult UpdateImageDomain()
    {
        return Ok();
    }
}