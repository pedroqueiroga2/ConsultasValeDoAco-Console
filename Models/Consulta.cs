using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models;

internal class Consulta
{   
    Random random = new Random();
 

    public Consulta(Medico medico, DateTime data, Cliente cliente)
    {
        Id = random.Next(10000);
        Medico = medico;
        Cliente = cliente;
        Data = data;
    }

    public int Id { get; }
    public Medico Medico { get;}

    public Cliente Cliente { get; }
    public DateTime Data { get;}

 }


