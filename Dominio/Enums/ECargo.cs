using System.ComponentModel;

namespace Fenacon.Dominio
{
    public enum ECargo
    {
        [Description("Estagiario")]
        Estagiario = 0,
        [Description("Tecnico")]
        Tecnico = 1,
        [Description("Analista")]
        Analista = 2,
        [Description("Gerente")]
        Gerente = 3
    }
}
