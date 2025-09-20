using System.Reflection.Metadata;
using ExemploExplorando.Models;
using System.Globalization;


DateTime data = DateTime.Parse("13/09/2003 13:45");
Console.WriteLine(data);

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