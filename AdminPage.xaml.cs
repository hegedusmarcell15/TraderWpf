using System.Windows.Controls;

namespace TraderWpf
{
    /// <summary>
    /// Interaction logic for AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        private readonly DatabaseStatements _databaseStatements = new DatabaseStatements();
        private readonly MainWindow _mainWindow;
        public AdminPage(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            userDataGrid.ItemsSource = _databaseStatements.UserList();
        }
    }
}
