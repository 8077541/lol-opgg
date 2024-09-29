using Microsoft.EntityFrameworkCore;
using opggApi.Data;
using opggApi.Interfaces;
using opggApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddHttpClient();

builder.Services.AddScoped<IProfileInterface, ProfileRepository>();
builder.Services.AddScoped<IMatchInterface, MatchRepository>();
builder.Services.AddScoped<IRuneInterface, RuneRepository>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddCors(p =>
    p.AddPolicy(
        "corspolicy",
        build =>
        {
            build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
        }
    )
);
var app = builder.Build();
app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("corspolicy");
app.UseHttpsRedirection();

app.Run();
