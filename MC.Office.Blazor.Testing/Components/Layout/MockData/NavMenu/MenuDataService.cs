namespace MC.Office.Blazor.Testing.Components.Layout.MockData.NavMenu
{
    using System.Collections.Generic;
    public class MenuDataService
    {
        public List<MenuItem> GetMenuItems(string category)
        {
            return category switch
            {
                "User Management" => GetUserManagementMenu(),
                "Settings" => GetSettingsMenu(),
                "Permissions" => GetPermissionsMenu(),
                "Roles" => GetRolesMenu(),
                "Access Control" => GetAccessControlMenu(),

                "Dashboard" => GetDashboardMenu(),
                "Reports" => GetReportsMenu(),
                "Analytics" => GetAnalyticsMenu(),
                "Logs" => GetLogsMenu(),
                "Monitoring" => GetMonitoringMenu(),

                "Profile" => GetProfileMenu(),
                "Notifications" => GetNotificationsMenu(),
                "Preferences" => GetPreferencesMenu(),
                "Security" => GetSecurityMenu(),
                "Privacy" => GetPrivacyMenu(),

                "Admin Panel" => GetAdminPanelMenu(),
                "Audit Trail" => GetAuditTrailMenu(),
                "Configuration" => GetConfigurationMenu(),
                "System Settings" => GetSystemSettingsMenu(),
                "Backup" => GetBackupMenu(),

                _ => GetDefaultMenu()
            };
        }

        #region MCIC Menus

        private List<MenuItem> GetUserManagementMenu() => new()
    {
        new MenuItem { Id = "users", Text = "ผู้ใช้ทั้งหมด", NavigateUrl = "/users", IconCssClass = "fa-solid fa-users" },
        new MenuItem { Id = "add-user", Text = "เพิ่มผู้ใช้", NavigateUrl = "/users/add", IconCssClass = "fa-solid fa-user-plus", IsNew = true },
        new MenuItem { Id = "user-groups", Text = "กลุ่มผู้ใช้", NavigateUrl = "/users/groups", IconCssClass = "fa-solid fa-user-group" },

        new MenuItem { Id = "import-export", Text = "IMPORT/EXPORT", IsGroupHeader = true, HasChildren = true },
        new MenuItem { Id = "import", ParentId = "import-export", Text = "Import Users", NavigateUrl = "/users/import", IconCssClass = "fa-solid fa-file-import" },
        new MenuItem { Id = "export", ParentId = "import-export", Text = "Export Users", NavigateUrl = "/users/export", IconCssClass = "fa-solid fa-file-export" },

        new MenuItem { Id = "advanced", ParentId = "import-export", Text = "ADVANCED", IsGroupHeader = true, HasChildren = true },
        new MenuItem { Id = "bulk-import", ParentId = "advanced", Text = "Bulk Import", NavigateUrl = "/users/import/bulk", IconCssClass = "fa-solid fa-users-gear" },
        new MenuItem { Id = "csv-import", ParentId = "advanced", Text = "CSV Import", NavigateUrl = "/users/import/csv", IconCssClass = "fa-solid fa-file-csv" },
        new MenuItem { Id = "template", ParentId = "advanced", Text = "Download Template", NavigateUrl = "/users/import/template", IconCssClass = "fa-solid fa-download" },
    };

        private List<MenuItem> GetSettingsMenu() => new()
    {
        new MenuItem { Id = "general", Text = "General", NavigateUrl = "/settings/general", IconCssClass = "fa-solid fa-gear" },
        new MenuItem { Id = "appearance", Text = "Appearance", NavigateUrl = "/settings/appearance", IconCssClass = "fa-solid fa-palette" },
        new MenuItem { Id = "notifications-set", Text = "Notifications", NavigateUrl = "/settings/notifications", IconCssClass = "fa-solid fa-bell", HasBadge = true },

        new MenuItem { Id = "integrations", Text = "INTEGRATIONS", IsGroupHeader = true, HasChildren = true },
        new MenuItem { Id = "api", ParentId = "integrations", Text = "API", NavigateUrl = "/settings/integrations/api", IconCssClass = "fa-solid fa-plug" },
        new MenuItem { Id = "webhooks", ParentId = "integrations", Text = "Webhooks", NavigateUrl = "/settings/integrations/webhooks", IconCssClass = "fa-solid fa-webhook" },

        new MenuItem { Id = "social", ParentId = "integrations", Text = "SOCIAL MEDIA", IsGroupHeader = true, HasChildren = true },
        new MenuItem { Id = "facebook", ParentId = "social", Text = "Facebook", NavigateUrl = "/settings/integrations/facebook", IconCssClass = "fa-brands fa-facebook" },
        new MenuItem { Id = "twitter", ParentId = "social", Text = "Twitter", NavigateUrl = "/settings/integrations/twitter", IconCssClass = "fa-brands fa-twitter" },
        new MenuItem { Id = "linkedin", ParentId = "social", Text = "LinkedIn", NavigateUrl = "/settings/integrations/linkedin", IconCssClass = "fa-brands fa-linkedin" },
    };

        private List<MenuItem> GetPermissionsMenu() => new()
    {
        new MenuItem { Id = "perm-overview", Text = "Overview", NavigateUrl = "/permissions", IconCssClass = "fa-solid fa-shield-halved" },
        new MenuItem { Id = "role-perm", Text = "Role Permissions", NavigateUrl = "/permissions/roles", IconCssClass = "fa-solid fa-user-shield" },
        new MenuItem { Id = "resource-perm", Text = "Resources", NavigateUrl = "/permissions/resources", IconCssClass = "fa-solid fa-lock" },
    };

        private List<MenuItem> GetRolesMenu() => new()
    {
        new MenuItem { Id = "all-roles", Text = "All Roles", NavigateUrl = "/roles", IconCssClass = "fa-solid fa-user-tag" },
        new MenuItem { Id = "create-role", Text = "Create Role", NavigateUrl = "/roles/create", IconCssClass = "fa-solid fa-plus" },
        new MenuItem { Id = "assign-roles", Text = "Assign Roles", NavigateUrl = "/roles/assign", IconCssClass = "fa-solid fa-user-check" },
    };

        private List<MenuItem> GetAccessControlMenu() => new()
    {
        new MenuItem { Id = "policies", Text = "Access Policies", NavigateUrl = "/access/policies", IconCssClass = "fa-solid fa-file-contract" },
        new MenuItem { Id = "ip-whitelist", Text = "IP Whitelist", NavigateUrl = "/access/ip", IconCssClass = "fa-solid fa-network-wired" },
        new MenuItem { Id = "2fa", Text = "Two-Factor Auth", NavigateUrl = "/access/2fa", IconCssClass = "fa-solid fa-mobile-screen" },
    };

        #endregion

        #region LF Menus

        private List<MenuItem> GetDashboardMenu() => new()
    {
        new MenuItem { Id = "dash-overview", Text = "Overview", NavigateUrl = "/dashboard", IconCssClass = "fa-solid fa-chart-line" },
        new MenuItem { Id = "analytics-dash", Text = "Analytics", NavigateUrl = "/dashboard/analytics", IconCssClass = "fa-solid fa-chart-pie" },
        new MenuItem { Id = "realtime", Text = "Real-time", NavigateUrl = "/dashboard/realtime", IconCssClass = "fa-solid fa-bolt", HasBadge = true },
    };

        private List<MenuItem> GetReportsMenu() => new()
    {
        new MenuItem { Id = "sales-report", Text = "Sales Reports", NavigateUrl = "/reports/sales", IconCssClass = "fa-solid fa-file-invoice-dollar" },
        new MenuItem { Id = "user-report", Text = "User Reports", NavigateUrl = "/reports/users", IconCssClass = "fa-solid fa-file-lines" },

        new MenuItem { Id = "custom-report", Text = "CUSTOM REPORTS", IsGroupHeader = true, HasChildren = true },
        new MenuItem { Id = "builder", ParentId = "custom-report", Text = "Report Builder", NavigateUrl = "/reports/custom/builder", IconCssClass = "fa-solid fa-file-circle-plus", IsNew = true },
        new MenuItem { Id = "saved", ParentId = "custom-report", Text = "Saved Reports", NavigateUrl = "/reports/custom/saved", IconCssClass = "fa-solid fa-bookmark" },

        new MenuItem { Id = "templates", ParentId = "custom-report", Text = "TEMPLATES", IsGroupHeader = true, HasChildren = true },
        new MenuItem { Id = "monthly", ParentId = "templates", Text = "Monthly Template", NavigateUrl = "/reports/custom/monthly", IconCssClass = "fa-solid fa-calendar-days" },
        new MenuItem { Id = "quarterly", ParentId = "templates", Text = "Quarterly Template", NavigateUrl = "/reports/custom/quarterly", IconCssClass = "fa-solid fa-calendar" },
        new MenuItem { Id = "annual", ParentId = "templates", Text = "Annual Template", NavigateUrl = "/reports/custom/annual", IconCssClass = "fa-solid fa-calendar-check" },
    };

        private List<MenuItem> GetAnalyticsMenu() => new()
    {
        new MenuItem { Id = "traffic", Text = "Traffic", NavigateUrl = "/analytics/traffic", IconCssClass = "fa-solid fa-chart-simple" },
        new MenuItem { Id = "conversion", Text = "Conversions", NavigateUrl = "/analytics/conversion", IconCssClass = "fa-solid fa-arrow-trend-up" },
        new MenuItem { Id = "behavior", Text = "User Behavior", NavigateUrl = "/analytics/behavior", IconCssClass = "fa-solid fa-users-viewfinder" },
    };

        private List<MenuItem> GetLogsMenu() => new()
    {
        new MenuItem { Id = "system-logs", Text = "System Logs", NavigateUrl = "/logs/system", IconCssClass = "fa-solid fa-server" },
        new MenuItem { Id = "error-logs", Text = "Error Logs", NavigateUrl = "/logs/errors", IconCssClass = "fa-solid fa-triangle-exclamation", HasBadge = true },
        new MenuItem { Id = "access-logs", Text = "Access Logs", NavigateUrl = "/logs/access", IconCssClass = "fa-solid fa-right-to-bracket" },
    };

        private List<MenuItem> GetMonitoringMenu() => new()
    {
        new MenuItem { Id = "servers", Text = "Server Status", NavigateUrl = "/monitoring/servers", IconCssClass = "fa-solid fa-server", HasBadge = true },
        new MenuItem { Id = "performance", Text = "Performance", NavigateUrl = "/monitoring/performance", IconCssClass = "fa-solid fa-gauge-high" },
        new MenuItem { Id = "alerts", Text = "Alerts", NavigateUrl = "/monitoring/alerts", IconCssClass = "fa-solid fa-bell-exclamation" },
    };

        #endregion

        #region VLP Menus

        private List<MenuItem> GetProfileMenu() => new()
    {
        new MenuItem { Id = "my-profile", Text = "My Profile", NavigateUrl = "/profile", IconCssClass = "fa-solid fa-user" },
        new MenuItem { Id = "edit-profile", Text = "Edit Profile", NavigateUrl = "/profile/edit", IconCssClass = "fa-solid fa-user-pen" },
        new MenuItem { Id = "password", Text = "Change Password", NavigateUrl = "/profile/password", IconCssClass = "fa-solid fa-key" },
    };

        private List<MenuItem> GetNotificationsMenu() => new()
    {
        new MenuItem { Id = "all-notif", Text = "All", NavigateUrl = "/notifications", IconCssClass = "fa-solid fa-bell" },
        new MenuItem { Id = "unread", Text = "Unread", NavigateUrl = "/notifications/unread", IconCssClass = "fa-solid fa-envelope", HasBadge = true },
        new MenuItem { Id = "notif-settings", Text = "Settings", NavigateUrl = "/notifications/settings", IconCssClass = "fa-solid fa-sliders" },
    };

        private List<MenuItem> GetPreferencesMenu() => new()
    {
        new MenuItem { Id = "language", Text = "Language", NavigateUrl = "/preferences/language", IconCssClass = "fa-solid fa-language" },
        new MenuItem { Id = "theme", Text = "Theme", NavigateUrl = "/preferences/theme", IconCssClass = "fa-solid fa-paintbrush" },
        new MenuItem { Id = "timezone", Text = "Timezone", NavigateUrl = "/preferences/timezone", IconCssClass = "fa-solid fa-clock" },
    };

        private List<MenuItem> GetSecurityMenu() => new()
    {
        new MenuItem { Id = "sec-overview", Text = "Overview", NavigateUrl = "/security", IconCssClass = "fa-solid fa-shield" },
        new MenuItem { Id = "sessions", Text = "Active Sessions", NavigateUrl = "/security/sessions", IconCssClass = "fa-solid fa-laptop" },
        new MenuItem { Id = "history", Text = "Login History", NavigateUrl = "/security/history", IconCssClass = "fa-solid fa-clock-rotate-left" },
    };

        private List<MenuItem> GetPrivacyMenu() => new()
    {
        new MenuItem { Id = "privacy-set", Text = "Privacy Settings", NavigateUrl = "/privacy", IconCssClass = "fa-solid fa-user-lock" },
        new MenuItem { Id = "data-export", Text = "Export Data", NavigateUrl = "/privacy/export", IconCssClass = "fa-solid fa-download" },
        new MenuItem { Id = "delete-acc", Text = "Delete Account", NavigateUrl = "/privacy/delete", IconCssClass = "fa-solid fa-trash" },
    };

        #endregion

        #region VN Menus

        private List<MenuItem> GetAdminPanelMenu() => new()
    {
        new MenuItem { Id = "admin-dash", Text = "Dashboard", NavigateUrl = "/admin", IconCssClass = "fa-solid fa-gauge" },
        new MenuItem { Id = "system-info", Text = "System Info", NavigateUrl = "/admin/system", IconCssClass = "fa-solid fa-circle-info" },

        new MenuItem { Id = "database", Text = "DATABASE", IsGroupHeader = true, HasChildren = true },
        new MenuItem { Id = "db-tables", ParentId = "database", Text = "Tables", NavigateUrl = "/admin/database/tables", IconCssClass = "fa-solid fa-table-list" },
        new MenuItem { Id = "db-backup", ParentId = "database", Text = "Backup", NavigateUrl = "/admin/database/backup", IconCssClass = "fa-solid fa-database" },

        new MenuItem { Id = "maintenance-db", ParentId = "database", Text = "MAINTENANCE", IsGroupHeader = true, HasChildren = true },
        new MenuItem { Id = "optimize", ParentId = "maintenance-db", Text = "Optimize", NavigateUrl = "/admin/database/optimize", IconCssClass = "fa-solid fa-gauge-high" },
        new MenuItem { Id = "repair", ParentId = "maintenance-db", Text = "Repair", NavigateUrl = "/admin/database/repair", IconCssClass = "fa-solid fa-wrench" },
        new MenuItem { Id = "vacuum", ParentId = "maintenance-db", Text = "Vacuum", NavigateUrl = "/admin/database/vacuum", IconCssClass = "fa-solid fa-broom" },
    };

        private List<MenuItem> GetAuditTrailMenu() => new()
    {
        new MenuItem { Id = "all-activities", Text = "All Activities", NavigateUrl = "/audit", IconCssClass = "fa-solid fa-list-check" },
        new MenuItem { Id = "user-activities", Text = "User Activities", NavigateUrl = "/audit/users", IconCssClass = "fa-solid fa-user-clock" },
        new MenuItem { Id = "system-changes", Text = "System Changes", NavigateUrl = "/audit/system", IconCssClass = "fa-solid fa-code-commit" },
    };

        private List<MenuItem> GetConfigurationMenu() => new()
    {
        new MenuItem { Id = "app-config", Text = "Application", NavigateUrl = "/config/app", IconCssClass = "fa-solid fa-wrench" },
        new MenuItem { Id = "storage-config", Text = "Storage", NavigateUrl = "/config/storage", IconCssClass = "fa-solid fa-hard-drive" },

        new MenuItem { Id = "email-config", Text = "EMAIL", IsGroupHeader = true, HasChildren = true },
        new MenuItem { Id = "smtp", ParentId = "email-config", Text = "SMTP Settings", NavigateUrl = "/config/email/smtp", IconCssClass = "fa-solid fa-server" },
        new MenuItem { Id = "queue", ParentId = "email-config", Text = "Queue Settings", NavigateUrl = "/config/email/queue", IconCssClass = "fa-solid fa-list-ol" },

        new MenuItem { Id = "templates-email", ParentId = "email-config", Text = "TEMPLATES", IsGroupHeader = true, HasChildren = true },
        new MenuItem { Id = "welcome", ParentId = "templates-email", Text = "Welcome Email", NavigateUrl = "/config/email/templates/welcome", IconCssClass = "fa-solid fa-hand-wave" },
        new MenuItem { Id = "reset-password", ParentId = "templates-email", Text = "Reset Password", NavigateUrl = "/config/email/templates/reset", IconCssClass = "fa-solid fa-key" },
        new MenuItem { Id = "notification", ParentId = "templates-email", Text = "Notification", NavigateUrl = "/config/email/templates/notification", IconCssClass = "fa-solid fa-bell" },
    };

        private List<MenuItem> GetSystemSettingsMenu() => new()
    {
        new MenuItem { Id = "sys-general", Text = "General", NavigateUrl = "/system/general", IconCssClass = "fa-solid fa-gears" },
        new MenuItem { Id = "maintenance", Text = "Maintenance", NavigateUrl = "/system/maintenance", IconCssClass = "fa-solid fa-screwdriver-wrench" },
        new MenuItem { Id = "cache", Text = "Cache", NavigateUrl = "/system/cache", IconCssClass = "fa-solid fa-box-archive" },
    };

        private List<MenuItem> GetBackupMenu() => new()
    {
        new MenuItem { Id = "create-backup", Text = "Create Backup", NavigateUrl = "/backup/create", IconCssClass = "fa-solid fa-floppy-disk" },
        new MenuItem { Id = "restore", Text = "Restore", NavigateUrl = "/backup/restore", IconCssClass = "fa-solid fa-rotate-left" },
        new MenuItem { Id = "schedule", Text = "Schedule", NavigateUrl = "/backup/schedule", IconCssClass = "fa-solid fa-calendar-check" },
    };

        #endregion

        #region Default Menu

        private List<MenuItem> GetDefaultMenu() => new()
    {
        new MenuItem { Id = "home", Text = "Home", NavigateUrl = "/", IconCssClass = "dx-icon-home" },
        new MenuItem { Id = "counter", Text = "Counter", NavigateUrl = "/counter", IconCssClass = "dx-icon-refresh" },
        new MenuItem { Id = "weather", Text = "Weather", NavigateUrl = "/weather", IconCssClass = "dx-icon-cloud" },

        new MenuItem { Id = "ai-group", Text = "AI-POWERED EXTENSIONS", IsGroupHeader = true, HasChildren = true },
        new MenuItem { Id = "ai-chat", ParentId = "ai-group", Text = "AI Chat", NavigateUrl = "/ai-chat", IconCssClass = "fa-solid fa-comments", HasBadge = true },
        new MenuItem { Id = "rich-editor", ParentId = "ai-group", Text = "Rich Text Editor", NavigateUrl = "/rich-editor", IconCssClass = "fa-solid fa-file-pen" },
        new MenuItem { Id = "html-editor", ParentId = "ai-group", Text = "HTML Editor", NavigateUrl = "/html-editor", IconCssClass = "fa-solid fa-code" },
        new MenuItem { Id = "memo", ParentId = "ai-group", Text = "Memo", NavigateUrl = "/memo", IconCssClass = "fa-solid fa-note-sticky", IsNew = true },
        new MenuItem { Id = "grid-ai", ParentId = "ai-group", Text = "Grid", NavigateUrl = "/grid-ai", IconCssClass = "fa-solid fa-table" },
        new MenuItem { Id = "reports", ParentId = "ai-group", Text = "Reports", NavigateUrl = "/reports", IconCssClass = "fa-solid fa-chart-line" },

        new MenuItem { Id = "data-mgmt", Text = "DATA MANAGEMENT", IsGroupHeader = true, HasChildren = true },
        new MenuItem { Id = "grid-data", ParentId = "data-mgmt", Text = "Grid", NavigateUrl = "/grid", IconCssClass = "fa-solid fa-table-cells", HasBadge = true },
        new MenuItem { Id = "treelist", ParentId = "data-mgmt", Text = "TreeList", NavigateUrl = "/treelist", IconCssClass = "fa-solid fa-sitemap", HasBadge = true },
        new MenuItem { Id = "filter-builder", ParentId = "data-mgmt", Text = "Filter Builder", NavigateUrl = "/filter", IconCssClass = "fa-solid fa-filter", HasBadge = true },

        new MenuItem { Id = "advanced-data", ParentId = "data-mgmt", Text = "ADVANCED", IsGroupHeader = true, HasChildren = true },
        new MenuItem { Id = "pivot", ParentId = "advanced-data", Text = "Pivot Grid", NavigateUrl = "/pivot", IconCssClass = "fa-solid fa-table-pivot" },
        new MenuItem { Id = "scheduler", ParentId = "advanced-data", Text = "Scheduler", NavigateUrl = "/scheduler", IconCssClass = "fa-solid fa-calendar-days" },
        new MenuItem { Id = "gantt", ParentId = "advanced-data", Text = "Gantt Chart", NavigateUrl = "/gantt", IconCssClass = "fa-solid fa-chart-gantt" },

        new MenuItem { Id = "data-editors", Text = "DATA EDITORS", IsGroupHeader = true, HasChildren = true },
        new MenuItem { Id = "overview", ParentId = "data-editors", Text = "Overview", NavigateUrl = "/overview", IconCssClass = "fa-solid fa-circle-info" },
        new MenuItem { Id = "common-concepts", ParentId = "data-editors", Text = "Common Concepts", NavigateUrl = "/concepts", IconCssClass = "fa-solid fa-lightbulb" },
        new MenuItem { Id = "calendar", ParentId = "data-editors", Text = "Calendar", NavigateUrl = "/calendar", IconCssClass = "fa-solid fa-calendar" },
        new MenuItem { Id = "checkbox", ParentId = "data-editors", Text = "CheckBox", NavigateUrl = "/checkbox", IconCssClass = "fa-solid fa-square-check" },
        new MenuItem { Id = "color-palette", ParentId = "data-editors", Text = "Color Palette", NavigateUrl = "/colors", IconCssClass = "fa-solid fa-palette" },
        new MenuItem { Id = "combobox", ParentId = "data-editors", Text = "ComboBox", NavigateUrl = "/combobox", IconCssClass = "fa-solid fa-list" },
        new MenuItem { Id = "date-edit", ParentId = "data-editors", Text = "Date Edit", NavigateUrl = "/date", IconCssClass = "fa-solid fa-calendar-days" },
        new MenuItem { Id = "date-range", ParentId = "data-editors", Text = "Date Range Picker", NavigateUrl = "/daterange", IconCssClass = "fa-solid fa-calendar-week" },
        new MenuItem { Id = "dropdown", ParentId = "data-editors", Text = "DropDown Box", NavigateUrl = "/dropdown", IconCssClass = "fa-solid fa-caret-down" }
    };

        #endregion
    }
}
