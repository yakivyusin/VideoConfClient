using System.Configuration;

namespace VideoConfClient.Helpers
{
    /// <summary>
    /// Wrapper class for working with App.config
    /// </summary>
    public static class AppConfig
    {
        /// <summary>
        /// Server Main Image Endpoint
        /// </summary>
        public static string ServerEndpoint
        {
            get
            {
                return ConfigurationManager.AppSettings["ServerMainImageEndpoint"];
            }
        }
    }
}
