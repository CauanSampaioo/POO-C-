// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using exemploFundamentos.Models;




// Exercicio de arryas

List<string> nomes = new List<string>();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite os nomes");
    string nome = Convert.ToString(Console.ReadLine());
    nomes.Add(nome);
}

foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}










//////////////////////////////  2

// int[] numeros = new int[3];

// for (int i = 0; i < 3; i++)
// {
//     Console.WriteLine("Digite um número : ");
//     numeros[i] = Convert.ToInt32(Console.ReadLine());
// }

// Console.WriteLine("Calculo da média:");

// int soma = 0;
// for (int i = 0; i < numeros.Length; i++)
// {
//     soma += numeros[i];
// }
// Console.WriteLine($"A soma totao foi de - {soma}");
// double media = soma / numeros.Length;
// Console.WriteLine($"A média é = {media}");




////////////////////////////////   1
// int[] numeros = new int[5];

// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine($"Digite o número :" + i);
//     numeros[i] = int.Parse(Console.ReadLine());
// }

// Console.WriteLine("Os números digitados foram :");

// for (int i = 0; i < numeros.Length; i++)
// {
//     Console.WriteLine($"{numeros[i]}");
// }




























// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("Ba");
// listaString.Add("Mg");


// Console.WriteLine("Foreach");
// int contador = 0;
// foreach (string item in listaString)
// {
//     Console.WriteLine($"Posição N° {contador} - {item}");
//     contador++;
// }




// for (int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
// }















// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 73;
// arrayInteiros[2] = 232;
// arrayInteiros[3] = 42;

// int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length);

// Console.WriteLine("com o foreach");



// int contador = 0;
// foreach (int valor in arrayInteirosDobrados)
// {
//     Console.WriteLine($"Posição número - {contador} - {valor}");
//     contador++;
// }


// Classe Array.Resize( );
//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

//Console.WriteLine("com o foreach");

// int contador = 0;
// foreach (int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição número - {contador} - {valor}");
//     contador++;
// }

//Console.WriteLine("com o for");

// for (int i = 0; i < arrayInteiros.Length; i++)
// {
//     Console.WriteLine($"Posição número - {i} - {arrayInteiros[i]}");
// }






// Pessoa alguem = new Pessoa();
// alguem.nomeNome("Cauan Sampaio");
// alguem.idadeIdade(22);
// alguem.Apresentar();





// string opcao;
// bool exibirMenu = true;

// while (exibirMenu)
// {
//     Console.WriteLine("Digite a sua opção : ");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar Cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;

//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;

//         case "3":
//             Console.WriteLine("Apagar de cliente");
//             break;

//         case "4":
//             exibirMenu = false;
//             Environment.Exit(0);
//             break;

//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }
// }

// Console.WriteLine("O programa encerrou !");

















// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("digite um número: ");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;
// } while (numero != 0);
// Console.WriteLine($"Totalde de soma = {soma}");













// int numero = 5;
// int contador = 0;

// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} X {contador} = {contador * numero}");
//     if (contador == 5)
//     {
//         break;
//     }
//     contador++;
// }














// int numero = 5;

// for (int contador = 1; contador <= 1000000; contador++)
// {
//     Console.WriteLine($"{numero} X {contador} = {contador * numero}");
// }











//Calcularoda calc = new Calcularoda();

// calc.Multiplicar(5, 5);
// calc.Somar(5, 5);
// calc.Subtrair(5, 2);
// calc.Dividir(5, 10);
//calc.Potencia(2, 2);
//calc.RaizQuadrada(9);



// int numero = 10;

// Console.WriteLine(numero);

// Console.WriteLine($"Incrementando o {numero}");
// numero++;

// Console.WriteLine(numero);







 





// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vamos pedalar");
// }
// else
// {
//     Console.WriteLine("Não vamos ");
// }







// double media = 7.5;
// bool presença = true;


// if (presença && media >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }







// bool ehMaior = false;
// bool possuiAltorizaca = false;

// if (ehMaior || possuiAltorizaca)
// {
//     Console.WriteLine("Possui altorização! ");
// }
// else
// {
//     Console.WriteLine("Não possui altorização ! ");
// }









// Console.WriteLine("Digite uma letra : ");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("VOGAL");
//         break;
//     default:
//         Console.WriteLine("CONSOANTE");
//         break;
// }








// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0   && quantidadeEmEstoque >= quantidadeCompra;


// Console.WriteLine($"Qauntidade em eestoque = {quantidadeEmEstoque}");
// Console.WriteLine($"Qauntidade da compra = {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda = {possivelVenda}");


// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Ok venda realizada ! ");
// }
// else
// {
//     Console.WriteLine("Desculpe não temos a quantidade desejada disponivel ! ");
// }







// string a = "15";

// //int b = 0;

// int.TryParse(a, out int b);     //Tenta converter o a caso de erro imrpime b -> (out b)

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!  ");





// double a = 4 / (2 + 2);

// Console.WriteLine(a);





// int a = int.MaxValue;
// double b = a;

// Console.WriteLine("Valor de a -> b = " +b);





// int inteiro = 5;
// string a = Convert.ToString(inteiro);           //ToString() está presente em todos os tipos

// Console.WriteLine(a);




// //int a = Convert.ToInt32("5");     //melhor método retorna nulo(0) caso não tenha valor
// int a = int.Parse("5");

// Console.WriteLine(a);





// int a = 10;
// int b = 20;
// int c = a + b;

// c += 5;

// Console.WriteLine(c);



//string aprensentacao = "Olá seja bem vindo";


// DateTime dateTime = DateTime.Now.AddDays(12);
// Console.WriteLine(dateTime.ToString("dd/MM/yyyy HH:mm"));

 
// int quantidade = 1;
// Console.WriteLine("Valor da variável quantidade: " + quantidade + " int");

// quantidade = 100;
// Console.WriteLine("Valor da variável quantidade: " + quantidade + " int");

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine("\n\n");
// Console.WriteLine(aprensentacao + " string");
// Console.WriteLine("Valor da variável quantidade: " + quantidade + " int");
// Console.WriteLine("Valor da variável quantidade: " + altura.ToString("0.000") + " double");
// Console.WriteLine("Valor da variável quantidade: " + preco + " decimal");
// Console.WriteLine("Valor da variável quantidade: " + condicao + " condicao");

// Pessoa pessoaFisica1 = new Pessoa();

// pessoaFisica1.Nome = "Cauan";
// pessoaFisica1.Idade = 22;
// pessoaFisica1.Apresentar();



// Pessoa pessoaFisica2 = new Pessoa();

// pessoaFisica2.Nome = "Buta";
// pessoaFisica2.Idade = 26;
// pessoaFisica2.Apresentar();