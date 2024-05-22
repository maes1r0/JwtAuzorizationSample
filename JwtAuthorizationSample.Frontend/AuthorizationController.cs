using JwtAuthorizationSample.Frontend.Models;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthorizationSample.Frontend;

[Route("[controller]")]
public class AuthorizationController : Controller
{
    [HttpGet]
    public IActionResult Login()
    {
        return View("~/Pages/LoginPage.cshtml");
    }

    [HttpPost]
    public IActionResult Login(LoginForm loginForm)
    {
        return Ok("LOL!KEK!SUCKsess!");
    }
}