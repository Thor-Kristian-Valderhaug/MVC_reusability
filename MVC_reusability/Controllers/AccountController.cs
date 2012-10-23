using System;
using System.Web.Mvc;
using MVC_reusability.Domain;
using MVC_reusability.Models;

namespace MVC_reusability.Controllers
{
    public class AccountController : BaseController
    {
        public virtual ActionResult Index()
        {
            var domainModel = DomainFactory.GetAccount();
            var mvcModel = ToMvcModel(domainModel);

            return BaseView(mvcModel);
        }


        public virtual ActionResult ActionWithError()
        {
            var domainModel = DomainFactory.GetAccount();
            var mvcModel = ToMvcModel(domainModel);

            if(NoeSpennendeBuisnisslogikk())
                return Redirect("http://www.google.com");
            
            return View(mvcModel);
        }


        #region Private helper methods

        private static bool NoeSpennendeBuisnisslogikk()
        {
            return true;
        }

        private static AccountModel ToMvcModel(DomainAccountModel model)
        {
            return new AccountModel
                       {
                           ACommonProperty = model.Name,
                           AOtherCommonProperty = model.Alder
                       };
        }

        #endregion

    }
}