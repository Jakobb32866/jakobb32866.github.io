using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace PortfolioSite.Models;

public static class WorksData
{
    public static readonly List<WorkItem> All =
    [
        new WorkItem("wordpress-aws-ecs", "project", "2026-06", "Wordpress w kontenerach na AWS ECS w CloudFormation",
            "Wordpress in containers on AWS ECS using CloudFormation", ["AWS", "CloudFormation", "WordPress"],
            "https://github.com/Jakobb32866/AWS_ECS_WP", null),
        
        new WorkItem("spring-backpropagation-digit-classifier", "project", "2026-06", "Klasyfikator cyfr z propagacją wsteczną w Java Spring",
            "Digit classifier with backpropagation in Java Spring", ["Java", "Spring", "ML", "REST API", "HTML", "CSS", "JavaScript", "Claude Design"],
            "https://github.com/Jakobb32866/Digit_classifier_java_spring", null),
        
        new("the-abyss-game", "project", "2026-05", "Gra \"The Abyss\" w Pythonie",
            "\"The Abyss\" game in Python", ["Python", "Pygame"],
            "https://github.com/Jakobb32866/the_abyss_game_PPY", null),
        
        new("wordpress-aws-cloudformation", "project", "2026-05", "WordPress na AWS w CloudFormation",
            "WordPress on AWS with CloudFormation", ["AWS", "CloudFormation", "WordPress"],
            "https://github.com/Jakobb32866/cloudformation_wordpress_", null),
        
        new("k-means-iris", "project", "2026-05", "Algorytm k-śrenich do klasyfikacji danych iris",
            "K-means algorithm for Iris data clustering", ["C#", "ML"],
            "https://github.com/Jakobb32866/NAI_MPP_5/tree/main", null),
        
        new("ta-strona", "project", "2026-04",
            "Ta strona", "This website",
            ["Blazor", "C#", ".NET", "HTML", "CSS", "Github", "Git", "JavaScript", "Claude Design"],
            "https://github.com/Jakobb32866/jakobb32866.github.io", "https://jakobb32866.github.io")
    ];
}