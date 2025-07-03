using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testec_.Models
{
    public class Transacao
    {
        public string Tipo { get; set; }
        public decimal Valor { get; set; }
        public string Data { get; set; }
        public Transacao(string tipo, decimal valor)
        {
            Tipo = tipo;
            Valor = valor;
            Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
    public class Historico
    {
        private List<Transacao> transacoes = new List<Transacao>();
        public void AdicionarTransacao(string tipo, decimal valor)
        {
            transacoes.Add(new Transacao(tipo, valor));
        }
        public void MostrarTransacoes()
        {
            foreach (var t in transacoes)
            {
                Console.WriteLine($"[{t.Data}] {t.Tipo}: R${t.Valor}");
            }
        }
    }
}