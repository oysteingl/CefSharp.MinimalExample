using System.Windows;

namespace CefSharp.MinimalExample.Wpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var window = new Window{Content = BrowserWindow.Content};
            BrowserWindow.Parent.RemoveChild(BrowserWindow);
            window.Show();
        }
    }
}
