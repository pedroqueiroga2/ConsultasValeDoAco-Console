using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models;

internal class Cliente : Pessoa
{

    public Cliente(string cPF, string nome, short idade) : base(nome, idade)
    {
        CPF = cPF;
    }

    public string CPF { get; set; }
    


}
