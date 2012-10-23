using System;
using System.Web.Mvc;

namespace MVC_reusability
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            filters.Add(new AbortExecutionExceptionAttrubute());
        }
    }

    public class AbortExecutionExceptionAttrubute : HandleErrorAttribute
    {
        public new void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);

            bool notCorrectException = !(filterContext.Exception is AbortExecutionException);
            if (notCorrectException)
                return;

            var exception = filterContext.Exception as AbortExecutionException;

            filterContext.ExceptionHandled = true;
            filterContext.Result = exception.ActionResult;
        }
    }

    public class AbortExecutionException : Exception
    {
        public AbortExecutionException(ActionResult actionResult)
        {
            ActionResult = actionResult;
        }

        public ActionResult ActionResult { get; set; }
    }
}