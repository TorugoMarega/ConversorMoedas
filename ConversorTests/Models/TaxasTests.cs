namespace ConversorMoedas.Models.Tests
{
    [TestClass()]
    public class TaxasTests
    {
        [TestMethod()]
        public void GetUsdTest()
        {
            Taxas taxas = new Taxas();

            Double usd = 0.1711596;
            var taxaUsd = taxas.GetUsd();
            Assert.AreEqual(usd, taxaUsd);
        }

        [TestMethod()]
        public void GetEurTest()
        {
            Taxas taxas = new Taxas();
            Double eur = 0.1506955;
            var taxaEur = taxas.GetEur();
            Assert.AreEqual(eur, taxaEur);
        }
    }
}