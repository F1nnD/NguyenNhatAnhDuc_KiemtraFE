using System.Web.Mvc;

namespace NguyenNhatAnhDuc_KiemtraFE.Controllers
{
    public class HomeController : Controller
    {
        // Trang chủ, auto bump khi mở Solution 
        public ActionResult Index()
        {
            return View();
        }
    }
} 
