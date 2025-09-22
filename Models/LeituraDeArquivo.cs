using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class LeituraDeArquivo
    {
        public (bool Sucesso, string[] LeituraDELinhas, int QuantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] LeituraDELinhas = File.ReadAllLines(caminho);
                return (true, LeituraDELinhas, LeituraDELinhas.Count());
            }
            catch
            {
                return (false, new string[0] ,0);
            }            
        }
    }
}