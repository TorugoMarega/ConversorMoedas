namespace ConversorMoedas.Utils.Tests
{
    [TestClass()]
    public class EntradaHelperTests
    {
        [TestInitialize]
        public void Setup()
        {
            // Define a cultura para aceitar ponto como separador decimal
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }
        [TestMethod()]
        public void LerValorMonetario_DeveRetornarValorQuandoEntradaValida()
        {
            var originalIn = Console.In;

            var input = new StringReader("123.45"); //Simula a entrada do usuário
            Console.SetIn(input);

            var helper = new EntradaHelper();

            double resultado = helper.LerValorMonetario();

            Assert.AreEqual(123.45, resultado, 0.01); // tolerância de comparação
            Console.SetIn(originalIn); // restaura o Console original

        }

        [TestMethod()]
        public void LerValorMonetario_DeveRepetirAteEntradaValida()
        {
            var originalIn = Console.In;

            var input = new StringReader("abc\nxyz\n123.45"); //Simula a entrada do usuário
            Console.SetIn(input);

            var helper = new EntradaHelper();

            double resultado = helper.LerValorMonetario();

            Assert.AreEqual(123.45, resultado, 0.01); // tolerância de comparação
            Console.SetIn(originalIn); // restaura o Console original
        }

        [TestMethod()]
        public void LerMoeda_CodOrigemValido()
        {
            var originalIn = Console.In;

            Boolean origemDestino = true;
            int moeda = 0;
            int index = 2; // Simulando 3 moedas (0, 1, 2)

            var helper = new EntradaHelper();

            var input = new StringReader("0"); //Simula a entrada do usuário
            Console.SetIn(input);

            int resultado = helper.LerMoeda(origemDestino, ref moeda, index);
            Assert.AreEqual(0, resultado);
            Console.SetIn(originalIn); // restaura o Console original
        }

        [TestMethod()]
        public void LerMoeda_CodOrigemInvalido_RepeteAteEntradaValida()
        {
            var originalIn = Console.In;
            Boolean origemDestino = true;
            int moeda = 0;
            int index = 2; // Simulando 3 moedas (0, 1, 2)

            var helper = new EntradaHelper();

            var input = new StringReader("a\n99\n0"); // duas entradas inválidas, depois válida
            Console.SetIn(input);

            int resultado = helper.LerMoeda(origemDestino, ref moeda, index);
            Assert.AreEqual(0, resultado);

            Console.SetIn(originalIn); // restaura a entrada padrão
        }

        [TestMethod()]
        public void LerMoeda_CodDestinoValido()
        {
            var originalIn = Console.In;

            Boolean origemDestino = false;
            int moeda = 0;
            int index = 2; // Simulando 3 moedas (0, 1, 2)

            var helper = new EntradaHelper();

            var input = new StringReader("1"); //Simula a entrada do usuário
            Console.SetIn(input);

            int resultado = helper.LerMoeda(origemDestino, ref moeda, index);
            Assert.AreEqual(1, resultado);
            Console.SetIn(originalIn); // restaura o Console original
        }

        [TestMethod()]
        public void LerMoeda_CodDestinoInvalido()
        {
            var originalIn = Console.In;
            Boolean origemDestino = false;
            int moeda = 0;
            int index = 2; // Simulando 3 moedas (0, 1, 2)

            var helper = new EntradaHelper();

            var input = new StringReader("0\n2"); //Simula a entrada do usuário, primeira tentativa inválida, válido na segunda
            Console.SetIn(input);

            int resultado = helper.LerMoeda(origemDestino, ref moeda, index);
            Assert.AreEqual(2, resultado);
            Console.SetIn(originalIn); // restaura o Console original
        }

        [TestMethod()]
        public void LerMoeda_CodInvalido_MaiorIndexMoeda()
        {
            var originalIn = Console.In;
            Boolean origemDestino = false;
            int moeda = 0;
            int index = 2; // Simulando 3 moedas (0, 1, 2)

            var helper = new EntradaHelper();

            var input = new StringReader("3\n1"); //Simula a entrada do usuário, primeira tentativa inválida, válido na segunda
            Console.SetIn(input);

            int resultado = helper.LerMoeda(origemDestino, ref moeda, index);
            Assert.AreEqual(1, resultado);
            Console.SetIn(originalIn); // restaura o Console original
        }
    }
}