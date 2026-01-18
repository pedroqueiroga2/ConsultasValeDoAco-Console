using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models.Services;

internal class ListarConsultas
{

    public static void ListarConsulta(List<Consulta> listar) 
    {
        foreach (var i in listar) 
        {
            Console.WriteLine($"Id: {i.Id}\nData:{i.Data}\n");
        }
    }
}
