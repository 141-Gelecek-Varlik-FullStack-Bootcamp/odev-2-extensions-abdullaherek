using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;

namespace ODEV2_MVC.Infrastructure
{
    public class LoginFilter : Attribute, IActionFilter
    {
      
        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            context.Result = new RedirectToRouteResult(routeValues: new RouteValueDictionary(new { Controller = "", ActionContext = " " }));
            throw new NotImplementedException();
        }
    }
}
