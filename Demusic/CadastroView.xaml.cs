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

namespace Demusic
{
    public partial class CadastroView : Window
    {
        public CadastroView()
        {
            InitializeComponent();
        }

        private void ConfirmaCadastro()
        {
            string NomeUsuario = NomeBox.Text;
            string LoginUsuario = LoginBox.Text;
            string SenhaUsuario = SenhaBox.Text;

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
        }
    }
}