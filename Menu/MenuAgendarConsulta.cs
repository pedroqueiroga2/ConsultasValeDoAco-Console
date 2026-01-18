using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;
using ConsoleApp1.Models.Services;

namespace ConsoleApp1.Menu;

internal class MenuAgendarConsulta : Menu
{


    private AgendarConsulta agendarConsultas = new();
    public void Executar(Dictionary<string, Medico> medicoNomeRegistrado, Dictionary<string, Cliente> pacienteNomeRegistrado)
    {
        Console.WriteLine("Informe o nome do Médico");

        string nomeMedico = Console.ReadLine();
        if (medicoNomeRegistrado.ContainsKey(nomeMedico))
        {

            Console.WriteLine($"Informe seu nome: ");
            string nome = Console.ReadLine();
            if (pacienteNomeRegistrado.ContainsKey(nome))
            {
                DateTime data = DateTime.Now;
                Console.WriteLine($"Consulta realizada com o médico {nomeMedico}\n às {data}");
                agendarConsultas.RegistrarConsulta(medicoNomeRegistrado[nomeMedico],
                    pacienteNomeRegistrado[nome], data);
               
            }

        }
        else
        {
            Console.WriteLine("Não possuímos esse Médico em nosso cadastro.");
        }
       
    }
}
