using DataAcess;
using Microsoft.EntityFrameworkCore;
using Application.Abstractions;
using DataAcess.Repositories;

var builder = WebApplication.CreateBuilder(args);

//connect to database
var cs = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<SocialDbContext>(opt => opt.UseSqlServer(cs));

builder.Services.AddScoped<IPostRepository,PostRepository>();

var app = builder.Build();

app.UseHttpsRedirection();


app.Run();

