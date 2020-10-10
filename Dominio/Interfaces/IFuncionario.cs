using Interfaces;

namespace Fenacon.Dominio.Interfaces
{
    public interface IFuncionario : IRepositorio<Funcionario>
    {
        Funcionario GetByName(string nome);
    }
}
