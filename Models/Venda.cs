using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemploExplorando.Models
{
    public class Venda
    {
        public int Id { get; set; }

        //[JsonProperty("Nome_Produto")]
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }

    public void imprimir()
    {
        Console.WriteLine("\bLEITURA");
        Console.WriteLine($"_________________________________________________________________________");
        Console.WriteLine($"\t\tQuantidade - {Id}\n\t\tProduto - {Produto}\n\t\tPreco {Preco}\n\t\tData {DataVenda}");
        Console.WriteLine($"_________________________________________________________________________\n");
    }
    }

  
}