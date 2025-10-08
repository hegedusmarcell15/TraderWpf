using System.Windows;
using System.Windows.Controls;

namespace TraderWpf
{
    /// <summary>
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        private readonly DatabaseStatements db = new DatabaseStatements();
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, RoutedEventArgs e)
        {
            if (userPasswordTextBox1.Password == userPasswordTextBox2.Password)
            {
                var user = new
                {
                    UserName = userNameTextBox.Text,
                    FullName = userFullNameTextBox.Text,
                    UserPassword = userPasswordTextBox1.Password,
                    Salt = "",
                    Email = userEmailTextBox.Text

                };

                MessageBox.Show(db.AddNewUser(user).ToString());
            }
            else
            {
                MessageBox.Show("Eltérő jelszavak.");
            }

        }
    }
}
