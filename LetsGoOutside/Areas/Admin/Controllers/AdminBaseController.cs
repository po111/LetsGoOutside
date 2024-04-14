using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static LetsGoOutside.Core.Constants.AdministratorConstants;

namespace LetsGoOutside.Areas.Admin.Controllers
{
    [Area(AdminAreaName)]
    [Authorize(Roles =AdminRole)]
    public class AdminBaseController : Controller
    {
        
    }
}
