// See https://aka.ms/new-console-template for more information
using ConversorMoedas.Models;
using ConversorMoedas.Services;
using ConversorMoedas.Utils;

void start() {
    ConversorService conversorService = new ConversorService();
    EntradaHelper entradaHelper = new EntradaHelper();
    List<Moeda> moedas = conversorService.CriaMoedas();
    var moedaOrigem = 0;
    var moedaDestino = 0;

    Console.WriteLine("---------------------------CONVERSOR DE MOEDAS------------------------------");
    Console.WriteLine("Escolha a moeda de origem:");
    Console.WriteLine("0 - Real");
    entradaHelper.LerMoeda(true, moedaOrigem);

    Console.WriteLine("Escolha a moeda de destino:");
    Console.WriteLine("1 - Dólar \n2 - Euro");
    entradaHelper.LerMoeda(false, moedaDestino);

    Console.WriteLine("Moeda de Origem: "+moedas[moedaOrigem].Nome+"  ----->   Moeda de destino: " + moedas[moedaDestino].Nome);
    entradaHelper.DesejaContinuar();
    Double valor = entradaHelper.LerValorMonetario();
    conversorService.ExibeConversoes(valor, moedas[moedaOrigem], moedas[moedaDestino]);
    entradaHelper.PararPrograma();
}

start();