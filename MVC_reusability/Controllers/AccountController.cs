﻿using System;
using System.Web.Mvc;
using MVC_reusability.Models;

namespace MVC_reusability.Controllers
{
    public class AccountController : BaseController
    {
        public virtual ActionResult Index()
        {
            var model = new AccountModel
                            {
                                ACommonProperty = "Noe felles info",
                                AOtherCommonProperty = "Enda mer felles info"
                            };

            return BaseView(model);
        }


        public virtual ActionResult ActionWithError()
        {
            var model = new AccountModel
            {
                ACommonProperty = "Info som ikke brukes",
                AOtherCommonProperty = "Enda mer felles info som ikke brukes"
            };

            if(NoeSpennendeBuisnisslogikk())
                return Redirect("http://www.google.com");
            
            return View(model);
        }

        private static bool NoeSpennendeBuisnisslogikk()
        {
            return true;
        }
    }
}