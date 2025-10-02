using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        protected string Nome { get; set; } = string.Empty;
        protected int Idade { get; set; }

        public virtual void apresentar()
        {
            Console.WriteLine($"Olá eu sou {Nome} e tenho {Idade} anos");
        }
    }
}