using System.Windows;

namespace TraderWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StartWindow.Navigate(new LoginPage(this));
        }
    }
}
