using Microsoft.AspNetCore.Mvc;

namespace ci_cd_test.Controllers;

[ApiController]
[Route("/test")]
public class TestController : ControllerBase
{

    [HttpGet]
    public string Get()
    {
       return "karabuk";
    }
}
