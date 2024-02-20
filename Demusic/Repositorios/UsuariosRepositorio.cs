using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Demusic.Modelos;

namespace Demusic.Repositorios
{
    public class UsuariosRepositorio
    {
        private const string ConnectionString = "Data Source=localhost;Initial Catalog=Demusics;Integrated Security=False;User Id=sa;Password=super990025;";

        public void InserirUsuario(Usuarios usuarios)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                string sql = $@"
INSERT INTO [dbo].[Usuario]
           ([Login]
           ,[Senha]
           ,[Nome]
           ,[Email])
     VALUES
           ('{usuarios.Login}'
           ,'{usuarios.Password}'
           ,'{usuarios.Nome}'
           ,'{usuarios.Email}')
        ";
                command.CommandText = sql; 
                int qtd = command.ExecuteNonQuery(); 
                Console.WriteLine("Linhas afetadas:" + qtd);
            }
        }
    }
}
