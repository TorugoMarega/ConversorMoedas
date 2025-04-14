using ConversorMoedas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoedas.Services
{
    class ConversorService
    {
        private List<Moeda> _moedas = new List<Moeda>();
        private Taxas _taxas = new Taxas();

        //Mostra os resultados da conversão para todas as moedas
        public void ExibeConversoes(Double valorOriginal, Moeda moedaOrigem, Moeda moedaDestino) {
            Console.WriteLine($"Valor em: {moedaOrigem.Nome}: {valorOriginal}");
            Console.WriteLine($"Valor em {moedaDestino.Nome}: {this.ConverterMoeda(valorOriginal, moedaDestino)} {moedaDestino.Simbolo}");
        }

        private Double ConverterMoeda(Double valorOrigem, Moeda moedaDestino)
        {
            var valorConvertido = valorOrigem * moedaDestino.TaxaConversao;
            return valorConvertido;
        }

        public List<Moeda> CriaMoedas() {
            Moeda brl = new Moeda();
            brl.TaxaConversao = 0.0; // Real não tem taxa de conversão
            brl.Nome = ("Real");
            brl.Simbolo = "BRL";

            Moeda usd = new Moeda();
            usd.TaxaConversao = this._taxas.getUsd();
            usd.Nome = ("Dólar");
            usd.Simbolo = "USD";

            Moeda eur = new Moeda();
            eur.TaxaConversao = this._taxas.getEur();
            eur.Nome = ("Euro");
            eur.Simbolo = "EUR";

            this._moedas.Add(brl);
            this._moedas.Add(usd);
            this._moedas.Add(eur);

            return this._moedas;
        }

        public void DebugMoedasToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var moeda in _moedas)
            {
                sb.AppendLine($"Nome: {moeda.Nome}, Simbolo: {moeda.Simbolo}, Taxa de Conversão: {moeda.TaxaConversao}");
            }
             Console.WriteLine(sb.ToString());
        }
    }
}
