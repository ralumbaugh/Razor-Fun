using Microsoft.AspNetCore.Mvc;
namespace RazorFun
{
    public class RazorController : Controller
    {
        [HttpGet("")]
        public ViewResult Foodlist()
        {
            return View("Foodlist");
        }
    }
}