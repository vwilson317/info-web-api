using BodyByBurgersInfoApi.BusinessLogic;
using Microsoft.ApplicationInsights.AspNetCore.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var options = new ApplicationInsightsServiceOptions { ConnectionString = builder.Configuration["ApplicationInsights:ConnectionString"] };
builder.Services.AddApplicationInsightsTelemetry(options: options);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<InfoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IService<Review, ReviewDto>, ReviewService>();
builder.Services.AddScoped<IService<Ingredient, IngredientDto>, IngredientService>();
builder.Services.AddScoped<IService<Picture, PictureDto>, PictureService>();
builder.Services.AddAutoMapper(typeof(MappingProfile));


var app = builder.Build();
app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
    app.UseSwagger();
    app.UseSwaggerUI();
// }

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
