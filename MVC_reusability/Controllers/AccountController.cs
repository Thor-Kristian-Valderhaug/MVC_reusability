﻿using System.Web.Mvc;
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
            //return View(model);
        }
    }
}