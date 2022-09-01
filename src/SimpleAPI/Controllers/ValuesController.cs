using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<string>> get()
    {
        return new string[] { "value1", "value2" };
    }

    [HttpGet("{id}")]
    public ActionResult<string> get(int id)
    {
        return "Les Jackson";
    }
}
