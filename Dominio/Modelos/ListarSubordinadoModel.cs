using System;

namespace Dominio.Modelos
{
    public class ListarSubordinadoModel
    {
        public string Nome { get; set; }
        public Guid? SupervisorId  { get; set; }
    }
}
