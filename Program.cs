using APIProject.Api;
using APIProject.Services.Users;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;


WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string userSecret = Environment.GetEnvironmentVariable("usersecret") ?? throw new ArgumentNullException(nameof(userEmail));
builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = "www.localhost.com",
            ValidAudience = "www.localhost.com",
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(userSecret))
        };
    });


builder.Services.AddControllers();
builder.Services.AddUserServiceDi();



//builder.Services.AddUserController(); 
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "APIProject v1"));
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapUserApi();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});


app.Run();
