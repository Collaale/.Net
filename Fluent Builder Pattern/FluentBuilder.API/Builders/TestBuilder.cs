using FluentBuilder.API.Models;
using FluentBuilder.API.Requests;

namespace FluentBuilder.API.Builders;

public class TestBuilder
{
    private readonly Test _test = new Test();

    public TestBuilder WithBasicInfo(string testName, string description, DateTime start, DateTime end)
    {
        _test.Id = Guid.NewGuid();
        _test.TestName = testName;
        _test.Description = description;
        _test.StartDate = start;
        _test.EndDate = end;
        return this;
    }

    public TestBuilder WithIsActive(bool isActive)
    {
        _test.IsActive = isActive;
        return this;
    }
    
    public TestBuilder WithTags(List<string> tags)
    {
        _test.Tags = tags;
        return this;
    }

    public TestBuilder WithDifficulty(TestDifficulty difficulty)
    {
        _test.Difficulty = difficulty;
        return this;
    }

    public TestBuilder WithMaxParticipants(int maxParticipants)
    {
        _test.MaxParticipants = maxParticipants;
        return this;
    }
    
    public TestBuilder WithSections(List<CreateTestRequestSection> sections)
    {
        _test.Sections = sections.Select(section => new TestSection
        {
            Title = section.Title,
            TimeLimit = section.TimeLimit,
            QuestionCount = section.QuestionCount
        }).ToList();
        return this;
    }

    public Test Build() => _test;
}