using System.Reflection.Metadata;
using ExemploExplorando.Models;
using System.Globalization;
using System.Collections;

Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add("BA", "Bahia");
estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");

Console.WriteLine(estados.Count);
Console.WriteLine(estados["BA"]);

// foreach (var estado in estados)
// {
//     Console.WriteLine($"{estado.Key} - {estado.Value}");
// }

// Console.WriteLine($"\n Removendo -> {estados.Remove("BA")} , {estados.Remove("SP")} \n");
// estados["MG"] = "MG Valor alterado";

// foreach (var estado in estados)
// {
//     Console.WriteLine($"{estado.Key} - {estado.Value}");
// }

string chave = "RJ";
if (estados.ContainsKey(chave))
{
    Console.WriteLine("Já existe a chave - " + chave);
}
else
{
    Console.WriteLine("É seguro adicionar a chave - " + chave);
    estados.Add(chave, "Adicionado");
    Console.WriteLine(chave + " Adicionado(a)");
}




























// Stack<int> pilha = new Stack<int>();
// pilha.Push(1);
// pilha.Push(4);
// pilha.Push(9);

// foreach (var item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo do totpo -> ({pilha.Pop()})");

// foreach (var item in pilha)
// {
//     Console.WriteLine(item);
// }























// Queue<int> fila = new Queue<int>();
// fila.Enqueue(2);
// fila.Enqueue(10);
// fila.Enqueue(20);

// foreach (int numero in fila)
// {
//     Console.WriteLine($"numero -> {numero}");
// }

// Console.WriteLine($"Removendo o primeiro a chegar na fila -> ({fila.Dequeue()})");

// foreach (int numero in fila)
// {
//     Console.WriteLine($"numero -> {numero}");
// }


























// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linhasLine in linhas)
//     {
//         Console.WriteLine(linhasLine);
//     }
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Primeiro catch {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Finaly");
// }




























// DateTime data = DateTime.Parse("13/09/2003 13:45");
// Console.WriteLine(data);

// DateTime data = DateTime.Now;
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());




























// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetaril = 2550.00M;

// Console.WriteLine(valorMonetaril.ToString("c"));
// Console.WriteLine(valorMonetaril.ToString("c", CultureInfo.CreateSpecificCulture("en-US")));




























// Pessoa p1 = new Pessoa("cauan", "Sampaio", 22);

// Pessoa p2 = new Pessoa("Atalia", "Dourado", 19);

// Pessoa p3 = new Pessoa("Caena", "Maglhães", 12);


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAluno();



// Curso cursoDev = new Curso();
// cursoDev.Nome = "Dev C#";
// cursoDev.Alunos = new List<Pessoa>();

// cursoDev.AdicionarAluno(p1);
// cursoDev.AdicionarAluno(p2);
// cursoDev.AdicionarAluno(p3);
// cursoDev.ListarAluno();
// Console.WriteLine($"Quantidade - {cursoDev.ObterQuantidadeDeAlunosMatriculados()}");

// cursoDev.RemoverAluno(p1);
// cursoDev.ListarAluno();
// Console.WriteLine($"Quantidade - {cursoDev.ObterQuantidadeDeAlunosMatriculados()}");