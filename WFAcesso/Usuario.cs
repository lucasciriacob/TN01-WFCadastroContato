using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAcesso
{
    public class Usuario
    {
      public Usuario (int codigo, string? login, string? senha, DateTime? DataCadastro)
        {
            codigo = codigo;

            login = login;
            senha = senha;
            DataCadastro = DataCadastro;

        }
        public Usuario() { }
        
        public static List<Usuario> ListaUsuarios = new List<Usuario>();
        public int Codigo { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; }
        public DateTime? DataCadastro { get; set; }

    }
}
