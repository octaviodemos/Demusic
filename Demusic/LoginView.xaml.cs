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
using Demusic.Modelos;
using Demusic.Repositorios;

namespace Demusic
{
    public partial class LoginView : Window
    {
        UsuariosRepositorio usuariosRepositorio;
        public LoginView()
        {
            InitializeComponent();
            LoginBox.Focus();
            usuariosRepositorio = new UsuariosRepositorio();
        }

        private void AcessaButton(object sender, RoutedEventArgs e)
        {
          string LoginUsuario = LoginBox.Text;
          string SenhaUsuario = SenhaBox.Password;

          Usuarios usuario = new Usuarios();
            {
                LoginUsuario = LoginBox.Text;
                SenhaUsuario = SenhaBox.Password;
            }

          if (string.IsNullOrEmpty(LoginUsuario))
            {
                MessageBox.Show("Digite seu login");
                LoginBox.Focus();
                return;
            }
          if (string.IsNullOrEmpty (SenhaUsuario))
            {
                MessageBox.Show("Digite a sua senha");
                SenhaBox.Focus();
                return;
            }

          bool ExibeLogin = usuariosRepositorio.ValidaLogin(usuario);
          if (ExibeLogin)
          {
             MessageBox.Show("Você possui login");
          }
          else
          {
             MessageBox.Show("Você não possui login");
          }

        

        }
        private void CadastroButton(object sender, RoutedEventArgs e)
        {
            CadastroView TelaCadastro = new CadastroView();
            TelaCadastro.Show();
        }
        private void SenhaBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                AcessaButton(null, null);
            }
        }
        private void LoginBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SenhaBox.Focus();
            }
        }
    }
}