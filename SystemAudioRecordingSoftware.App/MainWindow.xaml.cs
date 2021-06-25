// (c) Johannes Wolfgruber, 2021

using System.Windows;
using SystemAudioRecordingSoftware.Presentation.MainContent;

namespace SystemAudioRecordingSoftware.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainContentViewModel _mainContentViewModel;

        public MainWindow(MainContentViewModel mainContentViewModel)
        {
            InitializeComponent();
            _mainContentViewModel = mainContentViewModel;
            MainContent.DataContext = _mainContentViewModel;

            this.Loaded += MainWindowLoaded;
        }

        private void MainWindowLoaded(object sender, RoutedEventArgs e)
        {
            _mainContentViewModel.OnWindowLoaded();
        }
    }
}