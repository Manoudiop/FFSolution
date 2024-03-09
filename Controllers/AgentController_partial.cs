using FFSolution.Models;

namespace FFSolution.Controllers
{
    public partial class AgentController : Controller
    {
        //zaatar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateByNameOnly(string aname, int acountry)
        {
            Agent a = null;
            try
            {
                a = new Agent()
                {
                    AgentName = aname,
                    CountryID = acountry
                };
                db.Agent.Add(a);
                db.SaveChanges();
            }
            catch
            {
                return Json("0", JsonRequestBehavior.AllowGet);
            }
            return Json(a, JsonRequestBehavior.AllowGet);
        }
    }
}
