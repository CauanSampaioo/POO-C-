using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroDaConta, decimal saldoInicial)
        {
            NumeroDaConta = numeroDaConta;
            Saldo = saldoInicial;
        }
        public int NumeroDaConta { get; set; }

        private decimal Saldo { get; set; }

        public void sacar(decimal saque)
        {

            if (saque <= Saldo)
            {
                decimal resultado = Saldo -= saque;
                Console.WriteLine("Saque de " + resultado);
            }
            else
            {
                Console.WriteLine("Você só tem " + Saldo + " disponivél ");
            }
            
        }

        public void exibirSaldo()
        {
            Console.WriteLine("Seu Saldo disponivel é " + Saldo +"");
        }
    }
}