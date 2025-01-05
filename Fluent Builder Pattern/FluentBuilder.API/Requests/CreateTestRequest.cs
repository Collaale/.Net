using FluentBuilder.API.Models;

namespace FluentBuilder.API.Requests;

public class CreateTestRequest
{
    public string TestName { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsActive { get; set; }
    public List<string> Tags { get; set; }
    public TestDifficulty Difficulty { get; set; }
    public int MaxParticipants { get; set; }
    public List<CreateTestRequestSection> Sections { get; set; }
}