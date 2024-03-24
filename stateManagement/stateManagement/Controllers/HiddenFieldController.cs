
using Microsoft.AspNetCore.Mvc;

namespace stateManagement.Controllers;
using stateManagement.Models;
public class HiddenFieldController:Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult SetHiddenFieldValue()
    {
        User newUser = new User()
        {
            Id = 101,
            Name = "John",
        };
        return View();
    }
    [HttpPost]
    public IActionResult SetHiddenFieldValue(IFormCollection keyValues)
    {
        var id = keyValues["id"];
        return View();
    }
}