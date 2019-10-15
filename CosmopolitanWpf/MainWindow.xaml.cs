using System;
using System.Windows;
using CosmopolitanWpf.Views;

namespace CosmopolitanWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// The homePage.
        /// </summary>
        private Lazy<Home> homePage = new Lazy<Home>(() => new Home());

        /// <summary>
        /// The corePage.
        /// </summary>
        private Lazy<Core> corePage = new Lazy<Core>(() => new Core());

        /// <summary>
        /// The sdkPage.
        /// </summary>
        private Lazy<Sdk> sdkPage = new Lazy<Sdk>(() => new Sdk());

        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            ContentFrame.Content = homePage.Value;
            ButtonHome.IsChecked = true;
        }

        /// <summary>
        /// On ButtonHome Click, set homePage to ContentFrame.
        /// </summary>
        /// <param name="sender">The Sender.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            if (ContentFrame.Content != homePage.Value)
                ContentFrame.Content = homePage.Value;

            ButtonCore.IsChecked = false;
            ButtonSDK.IsChecked = false;

        }

        /// <summary>
        /// On ButtonCore Click, set corePage to ContentFrame.
        /// </summary>
        /// <param name="sender">The Sender.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void ButtonCore_Click(object sender, RoutedEventArgs e)
        {
            if (ContentFrame.Content != corePage.Value)
                ContentFrame.Content = corePage.Value;

            ButtonHome.IsChecked = false;
            ButtonSDK.IsChecked = false;
        }

        /// <summary>
        /// On ButtonSDK Click, set sdkPage to ContentFrame.
        /// </summary>
        /// <param name="sender">The Sender.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void ButtonSDK_Click(object sender, RoutedEventArgs e)
        {
            if (ContentFrame.Content != sdkPage.Value)
                ContentFrame.Content = sdkPage.Value;

            ButtonHome.IsChecked = false;
            ButtonCore.IsChecked = false;
        }
    }
}
