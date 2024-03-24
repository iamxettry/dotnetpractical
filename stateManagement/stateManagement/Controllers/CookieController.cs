using Microsoft.AspNetCore.Mvc;

namespace stateManagement.Controllers;

public class CookieController:Controller
{
    private IHttpContextAccessor accessor;

    public CookieController(IHttpContextAccessor accessor)
    {
        this.accessor = accessor;
    }

    public IActionResult Index()
    {

        return View();
    }

    public IActionResult WriteCookie()
    {
        Response.Cookies.Append("name", "John Doe");
        return View();
    } public IActionResult ReadCookie()
    {
        
        string name = accessor.HttpContext.Request.Cookies["name"];
        ViewBag.name = name;
        return View();
    }

}