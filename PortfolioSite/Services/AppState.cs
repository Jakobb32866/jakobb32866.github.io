namespace PortfolioSite.Services;

public class AppState
{
    public string Theme { get; private set; } = "dark";
    public string Lang  { get; private set; } = "pl";
    
    public event Action? OnChange;

    public void SetTheme(string theme) { Theme = theme; OnChange?.Invoke(); }
    public void SetLang(string lang)   { Lang  = lang;  OnChange?.Invoke(); }
}