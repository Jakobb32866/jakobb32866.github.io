namespace PortfolioSite.Models;

public record Skill(string Name, string Category);

public static class SkillsData
{
    public static readonly List<Skill> All =
    [
        new("C#",           "backend"),
        new(".NET",       "backend"),
        new("Blazor",       "backend"),
        new("Swing", "backend"),
        new("Java",         "backend"),
        new("SQL",   "backend"),
        new("AWS",          "backend"),
        new("Python",          "backend"),
        new("C++",          "backend"),
        
        new("HTML",   "frontend"),
        new("CSS",        "frontend"),

        new("Git",          "tools"),
        
        new("Rider",        "IDE"),
        new("IntelliJ",        "IDE"),
    ];
}