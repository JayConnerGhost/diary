namespace DiaryWeb.Services
{
    public class ConfigurationService : IConfigurationService
    {
        public ConfigurationService()
        {
            ApplicationName = "Dairy";
        }

        public string ApplicationName { get; set; }
    }
}