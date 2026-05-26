namespace PortfolioSite.Models;

public record Skill(string Name, string Category);

public static class SkillsData
{
    public static readonly List<Skill> All =
    [
        new("C#",           "backend"),
        new(".NET",       "backend"),
        new ("REST API", "backend"),
        new("Blazor",       "backend"),
        new("Java",         "backend"),
        new("SQL",   "backend"),
        new("AWS",          "backend"),
        new("CloudFormation",  "backend"),
        new("Python",          "backend"),
        new("C++",          "backend"),
        
        new("HTML",   "frontend"),
        new("CSS",        "frontend"),
        new("Swing", "frontend"),

        new("GitHub",          "tools"),
        new("Git",          "tools"),
        
        new("ML", "Artificial Intelligence"),
    ];
}