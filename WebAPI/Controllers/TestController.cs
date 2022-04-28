using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Model;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    

    [HttpGet(Name = "GetTestData")]
    public List<ImageServerInfo> Get()
    {
        
        var imageServerInfoList = new ImageServerInfo[]
        {
            new ImageServerInfo{ Cn = true, Remark = "test" },
            new ImageServerInfo{ Cn = false, Remark = "miou" },
        };

        return imageServerInfoList.ToList();
    }
}