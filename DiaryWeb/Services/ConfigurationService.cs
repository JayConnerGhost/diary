namespace DiaryWeb.Services
{
    public class ConfigurationService : IConfigurationService
    {
        public ConfigurationService()
        {
            ApplicationName = "Diary";
        }

        public string ApplicationName { get; set; }
    }
}