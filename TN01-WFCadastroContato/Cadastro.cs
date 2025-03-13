using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN01_WFCadastroContato
{
    public class Cadastro
    {
        public Cadastro(string? Nome, string? Sobrenome,string? DddTelefone, string? Email)
            
        {
            Nome = Nome;
            Sobrenome = Sobrenome;
            DddTelefone = DddTelefone;
            Email = Email;

        }
        public Cadastro()
        {

        }
        

        public static List<Cadastro> ListaPessoas = new List<Cadastro>();

        public string? Nome { get; set; }
        
        public string? Sobrenome { get; set; }

        public string? DddTelefone { get; set; }

        public string? TipoTelefone { get; set; }

        public string? Email { get; set; }
    }
}
