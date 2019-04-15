using System;

namespace OO
{
    class Usuario
    {
        int codigo = 123;
        string nome = "Rusbé";
        string curso = "Dev";
        string senha = "123";
        DateTime dataNascimento = new DateTime();

        public string InserirSenha() {   
            return senha;

        }
    }
}