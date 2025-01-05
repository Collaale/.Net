namespace FluentBuilder.API.Requests;

public class CreateTestRequestSection
{
    public string Title { get; set; }
    public int TimeLimit { get; set; }
    public int QuestionCount { get; set; }
}