using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LetsGoOutside.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        
    }
}
