using LetsGoOutside.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;

namespace LetsGoOutside.Attributes
{
    public class NotAuthorAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            IAuthorService? authorService = context.HttpContext.RequestServices.GetService<IAuthorService>();

            if (authorService == null )
            {
                context.Result = new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }

            if (authorService !=null 
                && authorService.ExistsByIdAsync(context.HttpContext.User.Id()).Result)
            {
                context.Result = new StatusCodeResult(StatusCodes.Status400BadRequest);
            }
        }
    }
}
