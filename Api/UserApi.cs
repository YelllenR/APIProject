using APIProject.Services.Users;
using Microsoft.AspNetCore.Mvc;

namespace APIProject.Api;

public static class UserApi
{
    public static void MapUserApi(this WebApplication app)
    {
        RouteGroupBuilder apiGroup = app
            .MapGroup("user")
            .WithDescription("All api use for users")
            .WithSummary("This is a summary")
            .RequireAuthorization();

        apiGroup.MapGet("", (HttpContext context) =>
        {
            Console.WriteLine(""); 
        });

        apiGroup.MapPost("id", (
            [FromQuery] int id, 
            [FromBody] UserLoginRequest userLogin,
            [FromServices] IUserService userService) =>
        {

            if (userLogin.Email == "aurelie@rosedarbon.com")
            {
                string token = userService.GetUserToken(userLogin.Email);
                return Results.Ok(token);
            }

            return Results.Forbid();
        })
        .AllowAnonymous();
    }
}