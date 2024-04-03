using LetsGoOutside.Controllers;
using LetsGoOutside.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;

namespace LetsGoOutside.Attributes
{
    public class MustBeOrganizerAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            IOrganizerService? organizerService = context.HttpContext.RequestServices.GetService<IOrganizerService>();

            if (organizerService == null)
            {
                context.Result = new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }

            if (organizerService != null
                && organizerService.ExistsByIdAsync(context.HttpContext.User.Id()).Result== false)
            {
                context.Result = new RedirectToActionResult(nameof(OrganizerController.Become), "Organizer", null);
            }
        }
    }
}
