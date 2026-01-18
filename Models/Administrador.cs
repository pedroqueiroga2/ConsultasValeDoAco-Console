using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models;

internal class Administrador
{
    public Administrador(string usuário)
    {
        Usuário = usuário;
        Senha = "Adm123";
    }

    private string Usuário { get;}
    public string Senha { get;} 
}
