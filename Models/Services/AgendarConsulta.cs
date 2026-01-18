using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models.Services;

internal class AgendarConsulta
{
    private List<Consulta> consultas = new();

    public void RegistrarConsulta(Medico medico, Cliente cliente, DateTime data) 
    {
        consultas.Add(new Consulta(medico, data, cliente));
    }

    public List<Consulta> Listar() 
    {
        if (consultas.Count == 0)
            Console.WriteLine("Não possuímos consultas cadastrados em nossa lista.");

        return consultas;
    }
}
