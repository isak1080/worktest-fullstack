namespace TrainingApp.Api.Models;

public class Athlete
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Sport { get; set; } = string.Empty;

    public int? GroupId { get; set; }
    public Group? Group { get; set; }
}
