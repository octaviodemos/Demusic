using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaDemusic.Modelos
{
    public class Usuarios
    {
        private int _id;
        private string _login;
        private string _password;

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
