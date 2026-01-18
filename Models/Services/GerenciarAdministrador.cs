using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models.Services;

internal class GerenciarAdministrador
{
    private Administrador _adm;

    public GerenciarAdministrador(Administrador adm, string usuario, string senha)
    {
        _adm = adm;
    }
    
    //public void TrocarSenha(string novaSenha) 
    //{
    //    _adm.Senha = novaSenha;
    //}
}
