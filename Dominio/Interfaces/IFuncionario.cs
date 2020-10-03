using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fenacon.Dominio.Interfaces
{
    public interface IFuncionario : IRepositorio<Funcionario>
    {
        Funcionario GetByName(string nome);
    }
}
