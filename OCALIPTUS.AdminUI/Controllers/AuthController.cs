using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OCALIPTUS.AdminUI.Models;
using OCALIPTUS.Application.CommonValues.Queries.GetValues;
using OCALIPTUS.Application.Users.Commands.CreateUser;

namespace OCALIPTUS.AdminUI.Controllers;

public class AuthController : BaseController
{
    [HttpGet]
    public async Task<IActionResult> Login()
    {
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> Register()
    {
        var genders = await Mediator.Send(new GetValuesQuery
        {
            ValueId = 4
        });

        var nationalities = await Mediator.Send(new GetValuesQuery
        {
            ValueId = 7
        });
        
        return View(new RegisterCommonValuesModel
        {
            Genders = genders.Data,
            Nationalities = nationalities.Data
        });
    }

    [HttpPost]
    public async Task<IActionResult> Register(CreateUserCommand command)
    {
        await Mediator.Send(command);
        return RedirectToAction(nameof(Login));
    }
}