using FFSolution.Models;

namespace FFSolution.Controllers
{
    [Authorize]
    public partial class AccountController : Controller
    {
        public ActionResult GetUserCredintionals()
        {
            using (FFSecurityDBEntities ff = new FFSecurityDBEntities())
            {
                var user = ff.AspNetUsers.FirstOrDefault(s => s.UserName == HttpContext.User.Identity.Name);
                if (user != null)
                {
                    var uJson = new
                    {
                        UserName = user.UserName,
                        IsAdministrator = user.IsAdministrator,
                        IsCustomerService = user.IsCustomerService,
                        IsOperation = user.IsOperation,
                        IsSales = user.IsSales,
                        IsAccounting = user.IsAccounting,
                        IsCustomerClearance = user.IsCustomClearance,
                    };

                    return Json(uJson, JsonRequestBehavior.AllowGet);
                }
                return Json("0", JsonRequestBehavior.AllowGet);
            }
        }
    }
}