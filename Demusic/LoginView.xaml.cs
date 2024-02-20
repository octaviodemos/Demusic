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
using Demusic;

namespace Demusic
{
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
            LoginBox.Focus();
        }

        private void CadastroButton(object sender, RoutedEventArgs e)
        {
            CadastroView TelaCadastro = new CadastroView();
            TelaCadastro.Show();

        }

        private void AcessaButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("teste");
        }

    }
}