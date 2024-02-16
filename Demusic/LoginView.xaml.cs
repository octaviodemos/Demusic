using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TelaDemusic
{
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
            LoginBox.Focus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("teste");
        }

        private void AcessaButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Teste");
        }

    }
}