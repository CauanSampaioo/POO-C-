using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count();
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAluno()
        {
            Console.WriteLine($"Alunos do cuso de {Nome}");

            for (int count = 0; count < Alunos.Count; count++)
            {
                Console.WriteLine($"N° {count + 1} - NOME: {Alunos[count].NomeCompleto} IDADE: {Alunos[count].Idade}");
            }


            //     int i = 0;
            //     foreach (Pessoa aluno in Alunos)
            //     {
            //         Console.WriteLine($"N° c{i + 1} - NOME: {aluno.NomeCompleto} IDADE: {aluno.Idade}");
            //         i++;
            //     }
            // }
        }
    }
}