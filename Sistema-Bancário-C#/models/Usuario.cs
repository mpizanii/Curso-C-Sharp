using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testec_.Models
{
    public class Usuario
    {
        public Usuario(string nome, string sobrenome, int idade)
        {
            Id = _proximoId++;
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }
        private static int _proximoId = 1;
        public int Id { get; }
        private string Nome { get; init; } = "Nome Usuário";
        private string Sobrenome { get; init; } = "Sobrenome Usuário";
        public string NomeCompleto => $"{Nome} {Sobrenome}";
        public int Idade { get; set; }
    }
}