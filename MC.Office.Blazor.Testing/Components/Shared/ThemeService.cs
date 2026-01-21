using DevExpress.Blazor;
public class ThemeService
{
    public ITheme ActiveTheme { get; private set; }
    public event Action ThemeChanged;

    public void SetTheme(ITheme theme)
    {
        ActiveTheme = theme;
        ThemeChanged?.Invoke();
    }

    //public DemoTheme ActiveTheme { get; private set; }
    //public ThemeState ThemeState { get; } = new();

    //public IReadOnlyList<DemoTheme> All { get; }

    //public void SetActiveThemeByName(string name)
    //{
    //    ActiveTheme = All.First(x => x.Name == name);
    //}
}
