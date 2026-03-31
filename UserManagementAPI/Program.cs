using UserManagementAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// ✅ Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<UserService>();

var app = builder.Build();

// ✅ Middleware
app.UseMiddleware<UserManagementAPI.Middleware.LoggingMiddleware>();

// ✅ Swagger (always enable)
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();