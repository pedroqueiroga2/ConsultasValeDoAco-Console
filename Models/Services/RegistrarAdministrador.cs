using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models.Services;

internal class RegistrarAdministrador
{
    private List<Administrador> administrador;

    public Administrador CriarNovoAdm(string senha, string usuario) 
    {
        Administrador admin = Administrador.Criar(senha, usuario);
        administrador.Add(admin);
        return admin;
    }
}
