using ConversorMoedas.Models;
using ConversorMoedas.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.Linq;

namespace ConversorTests.Services
{
    [TestClass]
    public class ConversorServiceTests
    {
        [TestInitialize]
        public void Setup()
        {
            // Define a cultura para aceitar ponto como separador decimal
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }
        [TestMethod]
        public void ConverterMoeda_DeveRetornarValorConvertidoCorreto()
        {
            var service = new ConversorService();
            double valor = 100;

            Moeda moeda = new Moeda
            {
                Nome = "Dólar",
                Simbolo = "USD",
                TaxaConversao = 5
            };

            var resultado = service.ConverterMoeda(valor, moeda);

            // Assert
            Assert.AreEqual(500, resultado);
        }

        [TestMethod]
        public void CriarMoedas_DeveConterMoedaDolar()
        {
            var service = new ConversorService();
            var resultado = service.CriaMoedas();

            // Assert
            Assert.IsTrue(resultado.Any(m => m.Nome == "Dólar" && m.Simbolo == "USD"));
        }

        [TestMethod]
        public void DebugMoedasToString()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            var service = new ConversorService();

            service.CriaMoedas();

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter); // Redireciona saída do console

            service.DebugMoedasToString();
            string resultado = stringWriter.ToString();

            StringAssert.Contains(resultado, "Nome: Dólar");
            StringAssert.Contains(resultado, "Simbolo: USD");

            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
        }
    }
}
