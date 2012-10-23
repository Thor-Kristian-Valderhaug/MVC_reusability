using System.Web.Mvc;
using MVC_reusability.Areas.Motorvogn.Models;

namespace MVC_reusability.Areas.Motorvogn.Controllers
{
    public class AccountController : MVC_reusability.Controllers.AccountController
    {
        #region Verbose, with lots of boilerplate code

        //public override ActionResult Index()
        //{
        //    ViewResultBase viewResult;

        //    var result = base.Index();
        //    if (NotViewResult(result))
        //        return result;

        //    viewResult = result as ViewResultBase;

        //    var motorvognAccountModel = GetModel<AccountModel>(viewResult);
        //    motorvognAccountModel.RegNr = "Et fint reg nummer";

        //    return View(motorvognAccountModel);
        //}

        //public override ActionResult ActionWithError()
        //{
        //    ViewResultBase viewResult;

        //    var result = base.ActionWithError();
        //    if (NotViewResult(result))
        //        return result;

        //    viewResult = result as ViewResultBase;

        //    var motorvognAccountModel = GetModel<AccountModel>(viewResult);
        //    motorvognAccountModel.RegNr = "Et fint reg nummer";

        //    return View(motorvognAccountModel);
        //}

        #endregion

        #region Less boilerplate
        
        public override ActionResult Index()
        {
            var motorvognAccountModel = GetPopulatedModel<AccountModel>(base.Index());
            var motorvognDomainModel = Domain.DomainFactory.GetMotorvognAccountModel();
            motorvognAccountModel.RegNr = motorvognDomainModel.RegNr;

            return View(motorvognAccountModel);
        }

        public override ActionResult ActionWithError()
        {
            
            var motorvognAccountModel = GetPopulatedModel<AccountModel>(base.ActionWithError());
            var motorvognDomainModel = Domain.DomainFactory.GetMotorvognAccountModel();
            motorvognAccountModel.RegNr = motorvognDomainModel.RegNr;

            return View(motorvognAccountModel);
        }

        #endregion
    }
}