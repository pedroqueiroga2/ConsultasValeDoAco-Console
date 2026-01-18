using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models;

internal abstract class Pessoa
{
    protected Pessoa(string nome, short idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public string Nome { get; }
    public short Idade { get; }
    

}
