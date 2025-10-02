using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploFundamentos.Models
{
    public class Pessoa
    {
        private string Nome { get; set; }
        private int Idade { get; set; }
        public string NomePorEsxtenso { get; set; }

        public void nomeNome(string nome)
        {
            Nome = nome;
        }

        public void idadeIdade(int idade)
        {
            Idade = idade;
        }

        public void Apresentar()
        {
            Console.WriteLine($"\nOlá, meu nome é {Nome}" + $", tenho {Idade} anos \n");
        }
    }
}
