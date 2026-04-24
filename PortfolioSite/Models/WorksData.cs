namespace PortfolioSite.Models;

public static class WorksData
{
    public static readonly List<WorkItem> All =
    [
        new("test-post", "project", "2026-04",
            "Ta strona", "This website",
            ["Blazor", "C#", ".NET", "CSS"],
            "https://github.com/jaszoch/portfolio", null),
    ];
}