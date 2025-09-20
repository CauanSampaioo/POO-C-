using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            SobreNome = sobrenome;
            Idade = idade;
        }

        private string _nome;
        private string _sobreNome;

        public string Nome
        {
            get => _nome;

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vázio !");
                }
                _nome = value;
            }
        }

        public string SobreNome
        {
            get => _sobreNome;

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Sobrenome não pode estar vázio");
                }
                _sobreNome = value;
            }
        }


        public string NomeCompleto => $"{Nome} {SobreNome}";
        
        private int _idade;
        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero!");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Idade: {Idade} Nome: {NomeCompleto}");
        }
    }
}