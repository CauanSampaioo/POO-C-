using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome, int idade, string nota) : base(nome, idade)
        {
            Nota = nota;
        }
        public string Nota { get; set; }

        public override void apresentar()
        {
                       Console.WriteLine($"Olá eu sou {Nome} e tenho {Idade} anos e nota {Nota}\n");
        }
    }
}