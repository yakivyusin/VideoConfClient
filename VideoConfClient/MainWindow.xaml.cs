using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using VideoConfClient.Core;

namespace VideoConfClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowInteraction interaction;

        public MainWindow()
        {
            InitializeComponent();
            Mouse.OverrideCursor = Cursors.None;

            interaction = new MainWindowInteraction(image, image90, image180, image270);
        }

        public void ApplicationClose(object sender, CancelEventArgs e)
        {
            interaction.Close();
        }
    }
}
