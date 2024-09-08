namespace APIProject.Services.Users;

public static class UserServiceDi
{
    public static IServiceCollection AddUserServiceDi(this IServiceCollection services)
    {
        services.AddTransient<IUserService, UserService>();

        return services;
    }
}
