using System.Collections.Concurrent;
using System.Globalization;
using System.Linq.Expressions;
using ConsoleApp1.Models;
using ConsoleApp1.Menu;
using ConsoleApp1.Models.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;


AgendarConsulta consulta = new();
RegistrarMedico registrarMedico = new();

Dictionary<string, Medico> medicoNomeRegistrado = new();
Dictionary<string, Cliente> pacienteNomeRegistrado = new();



//Medico m1 = new("980", "Dermatologista", "Pedro", 35);
//Cliente c1 = new("09201", "Lucas", 19);
//pacienteNomeRegistrado.Add(c1.Nome, c1);
//medicoNomeRegistrado.Add(m1.Nome, m1);


void ExibirLogo() 
{
Console.WriteLine(@"

░█▀▀░█▀█░█▀█░█▀▀░█░█░█░░░▀█▀░█▀█░█▀▀░░░█░█░█▀█░█░░░█▀▀░░░█▀▄░█▀█░░░█▀█░█▀▀░█▀█
░█░░░█░█░█░█░▀▀█░█░█░█░░░░█░░█▀█░▀▀█░░░▀▄▀░█▀█░█░░░█▀▀░░░█░█░█░█░░░█▀█░█░░░█░█
░▀▀▀░▀▀▀░▀░▀░▀▀▀░▀▀▀░▀▀▀░░▀░░▀░▀░▀▀▀░░░░▀░░▀░▀░▀▀▀░▀▀▀░░░▀▀░░▀▀▀░░░▀░▀░▀▀▀░▀▀▀
");

}

ExibirLogo();


while (true)
{
    Menu.MenuPrincipal();
    int op = int.Parse(Console.ReadLine());


switch (op) 
{
    case 1:
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

                    
                    consulta.RegistrarConsulta(medicoNomeRegistrado[nomeMedico], pacienteNomeRegistrado[nome], data );
                    
                }

            }
            else {
                Console.WriteLine("Não possuímos esse Médico em nosso cadastro.");
            }

            break;
            case 2:
                    ListarConsultas.ListarConsulta(consulta.Listar());
             break;

            case 3:

                Console.WriteLine("Informe o nome do médico: ");
                string novoMedicoNome= Console.ReadLine();
                Console.WriteLine("Informe a CRM do médico: ");
                string novoMedicoCrm = Console.ReadLine();
                Console.WriteLine("Informe a idade do médico: ");
                short novoMedicoIdade = short.Parse(Console.ReadLine());
                Console.WriteLine("Informe a especialidade do médico: ");
                string novoMedicoEspecialidade = Console.ReadLine();

                registrarMedico.RegistroMedico(novoMedicoCrm, novoMedicoEspecialidade, novoMedicoNome, novoMedicoIdade);
            
                break;
            case 4:
                ListarMedico.Listar(registrarMedico.Listar());
                break;



            default:
            Console.WriteLine("erro");
            break;
            
    }
  
}










