namespace ConversorMoedasTest
{
    [TestClass]
    public sealed class ConversorServiceTests
    {
        [TestClass]
        public class ConversorServiceTests
        {
            [TestMethod]
            public void ConverterMoeda_DeveRetornarValorConvertidoCorreto()
            {
                // Arrange
                var service = new ConversorService();
                double valor = 100;
                double taxa = 5;

                // Act
                var resultado = service.ConverterMoeda(valor, taxa);

                // Assert
                Assert.AreEqual(500, resultado);
            }
        }

    }
}
