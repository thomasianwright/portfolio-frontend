namespace WebApp.Core.Models;

public class JobExperience
{
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public string Position { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string StartDateString => StartDate.ToString("d");
    public string EndDateString => EndDate?.ToString("d") ?? "Present";
}