using Microsoft.AspNetCore.Mvc;

namespace BlogWebApi.WebCore.ViewComponents
{
    public class Search : ViewComponent
    {
        public IViewComponentResult Invoke(string s)
        {
            ViewBag.SearchString = s;
            return View();
        }
    }
}