using System.Web.Mvc;
using MVC_reusability.Areas.Motorvogn.Models;

namespace MVC_reusability.Areas.Motorvogn.Controllers
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

            var motorvognAccountModel = GetModel<AccountModel>(viewResult);
            motorvognAccountModel.RegNr = "Et fint reg nummer";

            return View(motorvognAccountModel);
        }

        public override ActionResult ActionWithError()
        {
            ViewResultBase viewResult;

            var result = base.ActionWithError();
            if (NotViewResult(result))
                return result;

            viewResult = result as ViewResultBase;

            var motorvognAccountModel = GetModel<AccountModel>(viewResult);
            motorvognAccountModel.RegNr = "Et fint reg nummer";

            return View(motorvognAccountModel);
        }
    }
}