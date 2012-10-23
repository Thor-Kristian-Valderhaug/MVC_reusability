using System.Web.Mvc;
using MVC_reusability.Areas.Innbo.Models;

namespace MVC_reusability.Areas.Innbo.Controllers
{
    public class AccountController : MVC_reusability.Controllers.AccountController
    {
        public override ActionResult Index()
        {
            ViewResultBase viewResult;

            var result = base.Index();
            if (NotViewResult(result))
                return result;

            viewResult = result as ViewResultBase;

            var innboAccountModel = GetModel<AccountModel>(viewResult);
            innboAccountModel.Adresse = "Et eller annet sted i oslo";
            return View(innboAccountModel);
        }


        public override ActionResult ActionWithError()
        {
            ViewResultBase viewResult;

            ActionResult result = base.ActionWithError();
            if (NotViewResult(result))
                return result;

            viewResult = result as ViewResultBase;

            var motorvognAccountModel = GetModel<AccountModel>(viewResult);
            motorvognAccountModel.Adresse = "En adresse til noe lurt";

            return View(motorvognAccountModel);
        }
    }
}