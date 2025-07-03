using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testec_.Models
{
    public class ContaCorrente
    {
        private static int _numero = 1;
        public int Numero { get; }
        public decimal Saldo { get; private set; } = 0;
        public Historico Historico { get; } = new Historico();
        public Usuario Usuario { get; }
        public ContaCorrente(Usuario usuario)
        {
            Numero = _numero++;
            Usuario = usuario;
        }
        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser maior que zero!");
            }
            Saldo += valor;
            Console.WriteLine($"Valor depositado, saldo atual: {Saldo}");
            Historico.AdicionarTransacao("Depósito", valor);
        }
        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do saque deve ser maior do que zero!");
            }
            else if (valor > Saldo)
            {
                Console.WriteLine("O valor não pode ser maior que o saldo");
            }
            else
            {
                Saldo -= valor;
                Historico.AdicionarTransacao("Saque", valor);
                Console.WriteLine($"Valor sacado, saldo atual: {Saldo}");
            }
        }
        public void MostrarInformações()
        {
            Console.WriteLine($"Numero: {Numero}\nSaldo: {Saldo}\nTitular: {Usuario.NomeCompleto}");
        }
    }
}