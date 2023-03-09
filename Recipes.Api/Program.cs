using Recipes.Application;
using Repices.Infrastructure;
using Repices.Infrastructure.Persistance;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var allowedUrl = builder.Configuration.GetValue<string>("Url:AllowedOriginUrls");

builder.Services.AddCors(o =>
{
    o.AddDefaultPolicy(b =>
    {
        b.AllowAnyHeader().AllowCredentials().WithOrigins(allowedUrl);
    });
});

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseCors();
app.UseAuthorization();

app.MapControllers();

var scope = app.Services.CreateScope();
ApplicationDbContextSeed.Initialize(scope.ServiceProvider.GetService<ApplicationDbContext>());

app.Run();
