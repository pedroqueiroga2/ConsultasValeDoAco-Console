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

Dictionary<string, Medico> medicoNomeRegistrado = new();

Medico m1 = new("1232", "teste", "Lucas", 19);
medicoNomeRegistrado.Add(m1.Nome, m1);


Dictionary<string, Cliente> pacienteNomeRegistrado = new();
Dictionary<string, Administrador> AdministradorRegistrados = new();
Administrador adm1 = new("Administrador", "Administrador", 99);
AdministradorRegistrados.Add(adm1.Senha, adm1);

//string senha = Console.ReadLine();
//if (AdministradorRegistrados.ContainsKey(senha)) 
//{
//    Console.WriteLine("Deu bom");
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










