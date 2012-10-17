using System.Web.Mvc;
using MVC_reusability.Models;

namespace MVC_reusability.Controllers
{
    public class BaseController : Controller
    {
        protected T GetModel<T>(ActionResult result) where T : BaseModel, new ()
        {
            var viewResult = (ViewResultBase) result;
            var model = viewResult.Model.To<T>();
            return model;
        }

         protected ViewResult BaseView(object model = null)
         {
             var viewName = RouteData.Values["Action"] as string;
             var controllerName = RouteData.Values["Controller"] as string;
             var masterName = string.Format("~/Views/{0}/{1}.cshtml", controllerName, viewName);

             return View("_Empty", masterName, model);
         }

         protected ViewResult NestedView(object model = null)
         {
             var viewName = RouteData.Values["Action"] as string;
             var controllerName = RouteData.Values["Controller"] as string;
             var masterName = string.Format("~/Views/{0}/{1}.cshtml", controllerName, viewName);

             return View(viewName, masterName, model);
         }

        protected bool NotViewResult(ActionResult result)
        {
            return !(result is ViewResultBase);
        }
    }
}