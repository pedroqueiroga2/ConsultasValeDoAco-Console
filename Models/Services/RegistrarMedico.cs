using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models.Services;

internal class RegistrarMedico
{
    
    private List<Medico> medicos = new();
    public Medico RegistroMedico(string crm, string especialidade, string nome,  short idade)
    {
        Medico m1 = new Medico(crm, especialidade, nome, idade);
        medicos.Add(m1);
        return m1;
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
