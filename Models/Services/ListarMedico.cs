using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models.Services;

internal class ListarMedico
{
    public static void Listar(List<Medico> listar)
    {
        if (listar != null)
        {
            foreach (Medico i in listar)
            {
                Console.WriteLine($"{i.Nome}, CRM - {i.CRM}");
            }
        }
        else {
            Console.WriteLine("Não possuímos médicos cadastrados em nossa lista.");
        }
    }
}
