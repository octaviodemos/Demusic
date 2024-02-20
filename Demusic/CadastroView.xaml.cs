using Demusic.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Demusic.Modelos;

namespace Demusic
{
    public partial class CadastroView : Window
    {
        List<Usuarios> usuarios;
        UsuariosRepositorio usuariosRepositorio;
        public CadastroView()
        {
            InitializeComponent();
           usuariosRepositorio = new UsuariosRepositorio();
        }

        private void ConfirmaCadastro(object sender, RoutedEventArgs e)
        {
            string NomeUsuario = NomeBox.Text;
            string EmailUsuario = EmailBox.Text;
            string LoginUsuario = LoginBox.Text;
            string SenhaUsuario = SenhaBox.Password;

            if (string.IsNullOrEmpty(NomeUsuario))
            {
                MessageBox.Show("Digite seu Nome");
                NomeBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(LoginUsuario))
            {
                MessageBox.Show("Digite seu Login");
                LoginBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(SenhaUsuario))
            {
                MessageBox.Show("Digite sua senha");
                SenhaBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(EmailUsuario))
            {
                MessageBox.Show("Digite seu Email");
                EmailBox.Focus();
                return;
            }

            Usuarios novoUsuario = new Usuarios
            {
                Nome = NomeUsuario,
                Email = EmailUsuario,
                Login = LoginUsuario,
                Password = SenhaUsuario
            };

            usuariosRepositorio.InserirUsuario(novoUsuario);

            MessageBox.Show("Dados Salvos");
            this.Close();
        }
    }
}