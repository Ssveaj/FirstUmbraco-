using FirstUmbraco_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace FirstUmbraco_.Controllers
{
    public class ContactFormController : SurfaceController
    {
        public ActionResult RenderContactForm()
        {
           
                return PartialView("_ContactForm", new ContactFormViewModel());
        }
        [HttpPost]
        public ActionResult HandleContactForm(ContactFormViewModel model)
        {
            if (!ModelState.IsValid)
            {

                return CurrentUmbracoPage();
            }

            MailMessage email = new MailMessage("noreply@example.local", model.Email)
            {
                Subject = "Contact Form Request",
                Body = model.Message
            };
            try
            {
                SmtpClient smtp = new SmtpClient();

                smtp.Send(email);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            TempData["IsSuccessful"] = true;

            return Redirect("/thanks-for-the-message");

        }
    }
}