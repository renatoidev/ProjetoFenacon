using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelos
{
    public class CadastrarFeriasModel
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public DateTime PeriodoAquisitivo { get; set; }
    }
}
