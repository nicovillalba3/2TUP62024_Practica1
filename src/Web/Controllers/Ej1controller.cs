using Microsoft.AspNetCore.Mvc;

namespace web;

[ApiController]
[Route("[controller]")]
public class Ej1controller : ControllerBase
{
    [HttpGet()]
    public int Get(int uno, int dos, int tres)
    {
        return uno + dos + tres;
    }
}