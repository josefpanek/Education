using Microsoft.AspNetCore.Mvc;

namespace AngularDemo.Conttrollers;

[Route("api/test")]
[ApiController]
public class TestController: ControllerBase
{
    [HttpGet]
    public List<int> GetNumbers()
    {
        return new List<int> { 1, 2, 3 };
    }
}