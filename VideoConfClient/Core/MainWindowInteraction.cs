using System.Windows.Controls;

namespace VideoConfClient.Core
{
    /// <summary>
    /// Main class that will be interact with main window.
    /// We don't use MVVM for better performance.
    /// </summary>
    public class MainWindowInteraction
    {
        private Image[] viewImages;

        public MainWindowInteraction(params Image[] images)
        {
            viewImages = images;
        }
    }
}
