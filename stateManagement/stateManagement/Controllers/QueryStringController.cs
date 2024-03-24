using Microsoft.AspNetCore.Mvc;
using stateManagement.Models;

namespace stateManagement.Controllers;

public class QueryStringController:Controller
{
    
    public IActionResult UserInfo(string name, Int32 id )
    {
        User newUser = new User()
        {
            Name = name,
            Id = id
        };
        return View(newUser);
    }
    
}