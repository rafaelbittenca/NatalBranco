using NatalBranco.Tools;
using NatalBranco.ViewModel;
using System;
using System.Web.Mvc;

namespace NatalBranco.Controllers
{
	public class HomeController : Controller
	{

		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Index(EmailContact obj)
		{
			try
			{
				var email = new Email();
				var msgBody = string.Format("<p>Hi {0},</p><p>This is a copy for your message.</p><p>Message:</p><p>{1}</p>", obj.ToName, obj.EMailBody);
				if (email.SendEmail(obj.ToEmail, obj.EmailBCC, obj.EmailCC, obj.ToName, obj.EmailSubject, msgBody))
				{
					ViewBag.Status = "Email Sent Successfully.";
					ModelState.Clear();
				}
			}
			catch (Exception ex)
			{
				ViewBag.Status = string.Format("Problem while sending email, Please check details. ({0})", ex.Message);
			}
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult Testimonials()
		{
			return View("Testimonials");
		}
	}
}