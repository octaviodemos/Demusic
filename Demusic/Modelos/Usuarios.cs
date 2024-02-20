using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Demusic.Modelos
{

    public class Usuarios
    {
        private int _id;
        private string _nome;
        private string _login;
        private string _password;
        private string _email;

        public int Id { get; set; }

        public string Nome { get; set; }
        public string Login { get; set; }
        public string Password 
        {
            get { return _password; }
            set
            {
                _password = value;
            }
        }

        public string Email { get; set; }
    }

}
