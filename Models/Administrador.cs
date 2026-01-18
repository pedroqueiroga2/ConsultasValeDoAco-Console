using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models;

internal class Administrador
{
    private Administrador(string usuário, string senha)
    {
        Usuário = usuário;
        Senha = senha;
    }

    private string Usuário { get;  set; }
    protected string Senha { get;   set; }

    internal static Administrador Criar(string usuario, string senha) 
    {
        return new Administrador(usuario, senha);
    }
}
