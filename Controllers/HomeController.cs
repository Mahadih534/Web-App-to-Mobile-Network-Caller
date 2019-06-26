using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace PhoneCall.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Call()
        {
            TwilioClient.Init("AC040f0vb1ca004eb2de14319d4da9fb", "2945430nv7c1bac7d025c3c06112bd3");

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                                                | SecurityProtocolType.Tls11
                                                | SecurityProtocolType.Tls12
                                                | SecurityProtocolType.Ssl3;


            var call = CallResource.Create(
            new PhoneNumber("+8801600102960"),
            from: new PhoneNumber("+19797057037"),
            url: new Uri("https://my.twiml.here")
          );


            return RedirectToAction("Index");
        }


    }
}