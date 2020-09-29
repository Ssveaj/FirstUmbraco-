using FirstUmbraco_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace FirstUmbraco_.Controllers
{
    public class ContactFormController : SurfaceController
    {
        [HttpPost]
        public ActionResult Submit(ContactFormViewModel model)
        {
            if (!ModelState.IsValid)
                return CurrentUmbracoPage();

                
            return RedirectToCurrentUmbracoPage();
        }
    }
}