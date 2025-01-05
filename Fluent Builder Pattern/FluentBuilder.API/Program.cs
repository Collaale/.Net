using FluentBuilder.API.Builders;
using FluentBuilder.API.Models;
using FluentBuilder.API.Requests;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

app.MapPost("/api/test", (CreateTestRequest createTestRequest) =>
{
    var test = new TestBuilder()
        .WithBasicInfo(
            createTestRequest.TestName,
            createTestRequest.Description,
            createTestRequest.StartDate,
            createTestRequest.EndDate)
        .WithIsActive(createTestRequest.IsActive)
        .WithTags(createTestRequest.Tags)
        .WithDifficulty(createTestRequest.Difficulty)
        .WithMaxParticipants(createTestRequest.MaxParticipants)
        .WithSections(createTestRequest.Sections)
        .Build();

    return Results.Ok(test);
});

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();