using APIProject.Model;
using APIProject.Services.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace APIProject.Controllers.UserControls;


[Authorize]
[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    private readonly IUserService _userService;

    [HttpPost]
    [AllowAnonymous]
    public ActionResult GetUserToken([FromQuery] string email)
    {
        if (email == "aurelie@rosedarbon.com")
        {
            string token = _userService.GetUserToken(email);
            return Ok(token);
        }

        return Unauthorized();
    }

}
