using FFSolution.Models;

namespace FFSolution.Controllers
{
    public partial class CommodityController : Controller
    {
        //zaatar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateByNameOnly(string cname)
        {
            Commodity c = null;
            try
            {
                c = new Commodity()
                {
                    CommodityName = cname
                };
                db.Commodity.Add(c);
                db.SaveChanges();
            }
            catch
            {
                return Json("0", JsonRequestBehavior.AllowGet);
            }
            return Json(c, JsonRequestBehavior.AllowGet);
        }

    }
}
