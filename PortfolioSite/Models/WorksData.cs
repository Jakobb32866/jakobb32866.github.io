using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace PortfolioSite.Models;

public static class WorksData
{
    public static readonly List<WorkItem> All =
    [
        new("the-abyss-game", "project", "2026-05", "Gra \"The Abyss\" w Pythonie",
            "\"The Abyss\" game in Python", ["Python", "Pygame"],
            null, null), //TODO dodać linka na githuba jak wrzucę
        
        new("wordpress-aws-cloudformation", "project", "2026-05", "WordPress na AWS w CloudFormation",
            "WordPress on AWS with CloudFormation", ["AWS", "CloudFormation", "WordPress"],
            "https://github.com/Jakobb32866/cloudformation_wordpress_", null),
        
        new("k-means-iris", "project", "2026-05", "Algorytm k-śrenich do klasyfikacji danych iris",
            "K-means algorithm for Iris data clustering", ["C#", "ML"],
            "https://github.com/Jakobb32866/NAI_MPP_5/tree/main", null),
        
        new("ta-strona", "project", "2026-04",
            "Ta strona", "This website",
            ["Blazor", "C#", ".NET", "HTML", "CSS", "Github", "Git", "JavaScript"],
            "https://github.com/Jakobb32866/jakobb32866.github.io", "https://jakobb32866.github.io")
    ];
}