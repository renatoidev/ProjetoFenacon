namespace Fenacon.Dominio
{
    public class Usuario 
    {
        public Usuario(){}
        
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string ConfirmaSenha { get; set; }

        public Usuario(string nome, string email, string senha, string confirmaSenha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            ConfirmaSenha = confirmaSenha;
        }
    }
}
