using System;

namespace Dominio
{
    public class Login
    {
        public Login(int? id, string email, string senha)
        {
            Id = id;
            Email = email;
            Senha = senha;
        }

        public Nullable<int> Id { get; private set; }

        public string Email { get; private set; }

        public string Senha { get; private set; }
    }
}
