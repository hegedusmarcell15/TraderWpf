using System.Windows;
using System.Windows.Controls;

namespace TraderWpf
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private readonly DatabaseStatements _databaseStatements = new DatabaseStatements();
        private readonly MainWindow _mainWindow;
        public LoginPage(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void logButton_Click(object sender, RoutedEventArgs e)
        {
            var user = new
            {
                Name = userNameTextBox.Text,
                Pass = userPasswordTextBox1.Password
            };
            if (_databaseStatements.LoginUser(user))
                _mainWindow.StartWindow.Navigate(new AdminPage(_mainWindow));
            else
                MessageBox.Show("Még nem regisztrált");
        }

        private void regLink_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.StartWindow.Navigate(new RegisterPage(_mainWindow));
        }
    }
}
