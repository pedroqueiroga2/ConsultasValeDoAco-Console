using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models;

internal class Medico : Pessoa
{
    public Medico(string cRM, string especialidade, string nome, short idade):base(nome,idade)
    {
        CRM = cRM;
        Especialidade = especialidade;
    }

    public string CRM { get; set; }
    public string Especialidade{ get; set; }
    
}
