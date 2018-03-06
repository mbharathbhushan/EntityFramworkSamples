using System.Web.Mvc;

namespace DBFirstApproch.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DBFirstApproachDBEntities db = new DBFirstApproachDBEntities();
          var status =  db.DeleteEmployee(1);
            var result = "Not Deleted";
            if(status == 1)
            {
                result = "Deleted";
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
    }
}