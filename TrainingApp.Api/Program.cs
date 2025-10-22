using Microsoft.EntityFrameworkCore;

using Scalar.AspNetCore;

using TrainingApp.Api.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TrainingContext>(opt =>
    opt.UseSqlite("data source=training-api.sqlite"));
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();

    app.MapOpenApi();
    app.MapScalarApiReference();
    app.MapGet("/", () => Results.Redirect("/scalar"));
}

app.MapGet("/api/test", () => "API is working!");
app.MapPost("/create-db", (TrainingContext db) =>
{
    db.Database.EnsureCreated();
    // TODO: Seed database if needed
    return Results.Ok($"Database created - {db.Athletes.Count()} athletes, {db.Groups.Count()} groups, {db.Exercises.Count()} exercises");
});
app.Run();
