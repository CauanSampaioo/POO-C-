using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public Professor()
        {

        }

        public Professor(string nome, int idade, decimal salario) : base(nome, idade)
        {
            Salario = salario;
        }
        public decimal Salario { get; set; }
        
        public override void apresentar()
        {
                       Console.WriteLine($"Olá eu sou {Nome} e tenho {Idade} anos e salarío {Salario}\n");
        }
    }
}