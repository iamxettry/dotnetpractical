
using Microsoft.AspNetCore.Mvc;
using stateManagement.Models;
using System.Text.Json;
namespace stateManagement.Controllers;

public class SessionController:Controller
{
   

    public IActionResult Index()
    {
        HttpContext.Session.SetString("Name","Raju");
        HttpContext.Session.SetInt32("Id", 12);
        // User newUser = new User()
        // {
        //     Name = "rajan",
        //     Id = 45
        // };
        // string userJson = JsonSerializer.Serialize(newUser);
        // HttpContext.Session.SetString("currentUser",userJson);
        return View();
    }

    public IActionResult setSession()
    {
        HttpContext.Session.SetString("Name","Raju");
        HttpContext.Session.SetInt32("Id", 106);
        return View();
    }
    [HttpPost]
    public IActionResult SetUserInSession(string name, Int32 id)
    {
     
        User newUser = new User()
        {
            Name = name,
            Id = id
        };
        string userJson = JsonSerializer.Serialize(newUser);
        HttpContext.Session.SetString("currentUser",userJson);
        return RedirectToAction("GetUserFromSession");
    }

    public IActionResult ViewSession()
    {
        ViewBag.Name = HttpContext.Session.GetString("Name");
        ViewBag.Id = HttpContext.Session.GetInt32("Id");
        return View();

    }

    public IActionResult Get()
    {
        User newUser = new User()
        {
            Name = HttpContext.Session.GetString("Name"),
            Id = HttpContext.Session.GetInt32("Id").Value
        };
        
        return View(newUser);
    }
    public IActionResult GetUserFromSession()
    {
        string userJson = HttpContext.Session.GetString("currentUser");

        User currentUser = JsonSerializer.Deserialize<User>(userJson);

        return View(currentUser);
    }
}