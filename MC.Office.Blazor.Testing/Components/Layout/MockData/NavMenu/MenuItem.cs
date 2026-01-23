namespace MC.Office.Blazor.Testing.Components.Layout.MockData.NavMenu
{
    public class MenuItem
    {
        public string Id { get; set; } = "";
        public string? ParentId { get; set; }
        public string Text { get; set; } = "";
        public string? NavigateUrl { get; set; }
        public string? IconCssClass { get; set; }
        public bool IsGroupHeader { get; set; }
        public bool IsNew { get; set; }
        public bool HasBadge { get; set; }
        public bool HasChildren { get; set; }
    }
}
