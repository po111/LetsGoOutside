using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static LetsGoOutside.Core.Constants.RoleConstants;

namespace LetsGoOutside.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles =AdminRole)]
    public class AdminBaseController : Controller
    {
        
    }
}
