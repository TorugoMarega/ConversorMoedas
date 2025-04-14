using ConversorMoedas.Models;
using ConversorMoedas.Services;
using ConversorMoedas.Utils;

void Start(ref bool op)
{
    ConversorService conversorService = new ConversorService();
    EntradaHelper entradaHelper = new EntradaHelper();
    List<Moeda> moedas = conversorService.CriaMoedas();
    Console.WriteLine("\nEscolha a moeda de origem:");
    Console.WriteLine("0 - Real");
    var codOrigem = 0;
    entradaHelper.LerMoeda(true, ref codOrigem, moedas.Count);

    Console.WriteLine("\nEscolha a moeda de destino:");
    Console.WriteLine("1 - Dólar \n2 - Euro");
    var codDestino = 0;
    entradaHelper.LerMoeda(false, ref codDestino, moedas.Count);

    Console.WriteLine("\nMoeda de Origem: " + moedas[codOrigem].Nome + "  ----->   Moeda de destino: " + moedas[codDestino].Nome);
    entradaHelper.DesejaContinuar(ref op);

    if (!op) return;

    double valor = entradaHelper.LerValorMonetario();
    conversorService.ExibeConversoes(valor, moedas[codOrigem], moedas[codDestino]);
    entradaHelper.DesejaContinuar(ref op);
}

EntradaHelper entradaHelper = new EntradaHelper();
Console.WriteLine("---------------------------CONVERSOR DE MOEDAS------------------------------");
bool op = true;
while (op)
{
    Start(ref op);
}