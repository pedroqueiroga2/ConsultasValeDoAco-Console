using System.Collections.Concurrent;
using System.Globalization;
using System.Linq.Expressions;
using ConsoleApp1.Models;
using ConsoleApp1.Menu;
using ConsoleApp1.Models.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;
using ConsoleApp1.Models.Data;


AgendarConsulta consulta = new();
RegistrarMedico registrarMedico = new();
RegistrarAdministrador registrarAdministrador = new();
Dictionary<string, Medico> medicoNomeRegistrado = new();
Cliente c1 = new("dad", "Pedro", 19);

Dictionary<string, Cliente> pacienteNomeRegistrado = new();
Dictionary<string, Administrador> AdministradorRegistrados = new();

//pacienteNomeRegistrado.Add(c1.Nome, c1);

//string senha = Console.ReadLine();
//if (AdministradorRegistrados.ContainsKey(senha)) 
//{
//    MenuAdministrador menuAdm = new();
//}

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
    MenuPrincipal.MenuOpcoes();
    int op = int.Parse(Console.ReadLine());


switch (op) 
{
    case 1:
            MenuAgendarConsulta m2 = new MenuAgendarConsulta();
            m2.Executar(medicoNomeRegistrado, pacienteNomeRegistrado);

            break;
            case 2:
                    ListarConsultas.ListarConsulta(consulta.Listar());
             break;

            case 3:

                MenuRegistrarMedico m3 = new(registrarMedico);
            m3.Executar(medicoNomeRegistrado);
            
                break;
            case 4:
                ListarMedico.Listar(registrarMedico.Listar());
                break;



            default:
            Console.WriteLine("erro");
            break;
            
    }
  
}










