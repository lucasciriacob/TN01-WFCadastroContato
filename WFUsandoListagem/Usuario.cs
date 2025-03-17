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
            login = login;
            senha = senha;
            codigo = codigo;
            DataCadastro = DataCadastro;

        }
        public Usuario() { }
        
        public static List<Usuario> ListaUsuarios = new List<Usuario>();
        public string? Login { get; set; }
        public string? Senha { get; set; }
        public int Codigo { get; set; }
        public DateTime? DataCadastro { get; set; }

    }
}
