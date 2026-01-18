using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models.Services;

internal class RegistrarMedico
{
    private List<Medico> medicos = new();
    public void RegistroMedico(string crm, string especialidade, string nome,  short idade)
    {
        medicos.Add(new Medico(crm, especialidade, nome, idade));
    }

    public List<Medico> Listar() 
    {
        if (medicos.Count == 0) 
        {
            Console.WriteLine("Não possuímos nenhum médico cadastrado em nossa lista.");
        }

        return medicos;
    }
}
