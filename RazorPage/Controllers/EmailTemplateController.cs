using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorPage.Controllers
{
    public class EmailTemplateController : Controller
    {
        // GET: EmailTemplate
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AncillaryProviderInformationTemplate()
        {
            StreamReader sr = new StreamReader(@"C:/Users/vijay.tummala/Documents/dataobj.json");
            string jsonString = sr.ReadToEnd();
            dynamic obj = JsonConvert.DeserializeObject<System.Dynamic.ExpandoObject>(jsonString);
            return View(obj.model);
        }

        public ActionResult AppointmentNotificationTemplate()
        {
            StreamReader sr = new StreamReader(@"C:/Users/vijay.tummala/Documents/dataobj.json");
            string jsonString = sr.ReadToEnd();
            dynamic obj = JsonConvert.DeserializeObject<System.Dynamic.ExpandoObject>(jsonString);
            return View(obj.model);
        }
        public ActionResult AuthorizationForSchedulingTemplate()
        {
            StreamReader sr = new StreamReader(@"C:/Users/vijay.tummala/Documents/dataobj.json");
            string jsonString = sr.ReadToEnd();
            dynamic obj = JsonConvert.DeserializeObject<System.Dynamic.ExpandoObject>(jsonString);
            return View(obj.model);
        }

        public ActionResult RequestForAncillaryServicesTemplate()
        {
            StreamReader sr = new StreamReader(@"C:/Users/vijay.tummala/Documents/dataobj.json");
            string jsonString = sr.ReadToEnd();
            dynamic obj = JsonConvert.DeserializeObject<System.Dynamic.ExpandoObject>(jsonString);
            return View(obj.model);
        }

        public ActionResult RequestStatusTemplate()
        {
            StreamReader sr = new StreamReader(@"C:/Users/vijay.tummala/Documents/dataobj.json");
            string jsonString = sr.ReadToEnd();
            dynamic obj = JsonConvert.DeserializeObject<System.Dynamic.ExpandoObject>(jsonString);
            return View(obj.model);
        }

        public ActionResult RequestSpecialistTemplate()
        {
            StreamReader sr = new StreamReader(@"C:/Users/vijay.tummala/Documents/dataobj.json");
            string jsonString = sr.ReadToEnd();
            dynamic obj = JsonConvert.DeserializeObject<System.Dynamic.ExpandoObject>(jsonString);
            return View(obj.model);
        }

        public ActionResult ReportAppointmentNotificationTemplate()
        {
            StreamReader sr = new StreamReader(@"C:/Users/vijay.tummala/Documents/dataobj.json");
            string jsonString = sr.ReadToEnd();
            dynamic obj = JsonConvert.DeserializeObject<System.Dynamic.ExpandoObject>(jsonString);
            return View(obj.model);
        }

        public ActionResult AppointmentToClinic()
        {
            StreamReader sr = new StreamReader(@"C:/Users/vijay.tummala/Documents/dataobj.json");
            string jsonString = sr.ReadToEnd();
            dynamic obj = JsonConvert.DeserializeObject<System.Dynamic.ExpandoObject>(jsonString);
            return View(obj.model);
        }
        public ActionResult OnlyRequestsStatus()
        {
            StreamReader sr = new StreamReader(@"C:/Users/vijay.tummala/Documents/dataobj.json");
            string jsonString = sr.ReadToEnd();
            dynamic obj = JsonConvert.DeserializeObject<System.Dynamic.ExpandoObject>(jsonString);
            return View(obj.model);
        }
    }
}