using Microsoft.AspNetCore.Mvc;

namespace StartupProject.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : Controller
    {
    }
}
