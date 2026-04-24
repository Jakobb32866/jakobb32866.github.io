namespace PortfolioSite.Models;

public record WorkItem(
    string       Slug,          // Chodzi o url-friendly url : >
    string       Type,          // "blog" | "project"
    string       Date,
    string       TitlePl,
    string       TitleEn,
    List<string> Tags,
    string?      GitHubUrl,
    string?      LiveUrl        //Czyli link do projektu
);