using System.ComponentModel;

namespace Fenacon.Dominio
{
    public enum ESituacao
    {
        [Description("Ativo")]
        Ativo = 0,
        [Description("Ferias")]
        Ferias = 1,
        [Description("Desligado")]
        Desligado = 2
    }
}