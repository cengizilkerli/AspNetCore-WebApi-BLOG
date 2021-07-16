using BlogWebApi.WebCore.ApiServices.Interfaces;
using BlogWebApi.WebCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlogWebApi.WebCore.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthApiService _authApiService;
        public AccountController(IAuthApiService authApiService)
        {
            _authApiService = authApiService;
        }
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> SignIn(AppUserLoginModel model)
        {
            if (await _authApiService.SignIn(model))
            {
                return RedirectToAction("Index", "Blog", new { @area = "Admin" });
            }

            return View();
        }
    }
}