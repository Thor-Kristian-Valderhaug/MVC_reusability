﻿using System.Web.Mvc;
using MVC_reusability.Models;

namespace MVC_reusability.Controllers
{
    public class BaseController : Controller
    {
         protected ViewResult BaseView(object model = null)
         {
             var viewName = RouteData.Values["Action"] as string;
             var controllerName = RouteData.Values["Controller"] as string;
             var masterName = string.Format("~/Views/{0}/{1}.cshtml", controllerName, viewName);

             return View("_Empty", masterName, model);
         }

        protected bool NotViewResult(ActionResult result)
        {
            return !(result is ViewResultBase);
        }

        protected T GetModel<T>(ActionResult result) where T : BaseModel, new()
        {
            var viewResult = (ViewResultBase)result;
            var model = viewResult.Model.To<T>();
            return model;
        }

        protected T GetPopulatedModel<T>(ActionResult actionResult)
            where T : BaseModel, new()
        {
            
            if (NotViewResult(actionResult))
                throw new AbortExecutionException(actionResult);

            var viewResult = actionResult as ViewResultBase;

            return GetModel<T>(viewResult);
        }
    }
}