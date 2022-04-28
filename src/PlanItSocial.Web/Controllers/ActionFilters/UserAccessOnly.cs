using PlanItSocial.Data;
using PlanItSocial.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanItSocial.Controllers.ActionFilters
{
    public class UserAccessOnly : Microsoft.AspNetCore.Mvc.Filters.ActionFilterAttribute, Microsoft.AspNetCore.Mvc.Filters.IActionFilter
    {
        private DAL _dal = new DAL();

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.RouteData.Values.ContainsKey("id"))
            {
                int id = int.Parse((string)context.RouteData.Values["id"]);
                if (context.HttpContext.User != null)
                {
                    var username = context.HttpContext.User.Identity.Name;
                    if (username != null)
                    {
                        var myevent = _dal.GetEvent(id);
                        if (myevent.User != null)
                        {
                            if (myevent.User.UserName != username)
                            {
                                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Home", action = "Not Found" }));
                            }
                        }
                    }
                }
            }
        }
    }
}
