﻿using System.Windows;

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
            BrowserWindow.Parent.RemoveChild(BrowserWindow);
            var window = new Window{Content = BrowserWindow.Content};
            window.Show();
        }
    }
}
