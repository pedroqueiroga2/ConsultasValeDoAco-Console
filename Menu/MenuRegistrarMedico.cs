using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;
using ConsoleApp1.Models.Services;

namespace ConsoleApp1.Menu;

internal class MenuRegistrarMedico
{

    private readonly RegistrarMedico _register;

    public MenuRegistrarMedico(RegistrarMedico register)
    {
        _register = register;
    }

    public void Executar(Dictionary<string, Medico> medicoNomeRegistrado) 
    {
        Console.WriteLine("Informe o nome do médico: ");
        string novoMedicoNome = Console.ReadLine();
        Console.WriteLine("Informe a CRM do médico: ");
        string novoMedicoCrm = Console.ReadLine();
        Console.WriteLine("Informe a idade do médico: ");
        short novoMedicoIdade = short.Parse(Console.ReadLine());
        Console.WriteLine("Informe a especialidade do médico: ");
        string novoMedicoEspecialidade = Console.ReadLine();

        try
        {
            medicoNomeRegistrado.Add(novoMedicoNome, _register.RegistroMedico(novoMedicoCrm,
            novoMedicoEspecialidade, novoMedicoNome, novoMedicoIdade));
        }
        catch (Exception error) 
        {
            Console.WriteLine($"Erro ao registrar o médico {error.Message }");
        }
        

    }
}
