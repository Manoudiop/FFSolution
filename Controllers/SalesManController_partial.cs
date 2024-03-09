using FFSolution.Models;

namespace FFSolution.Controllers
{
    public partial class SalesManController : Controller
    {
        [HttpGet]
        // GET: /SalesMan/Details
        public ActionResult DetailsForSalesMan()
        {
            // sales man ID accosiated with this login
            SalesMan salesman = db.SalesMan.Where(x => x.UserName == this.HttpContext.User.Identity.Name).FirstOrDefault();
            if (salesman == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View("Details", salesman);
        }

    }
}
