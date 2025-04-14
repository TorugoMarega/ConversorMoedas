using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoedas.Utils
{
    class EntradaHelper
    {
        public Double LerValorMonetario() { 
            Console.WriteLine("Digite o valor a ser convertido: ");
            string valor = Console.ReadLine();
            return Double.Parse(valor);
        }

        public void LerMoeda(Boolean origemDestino, int moedaOrigemDestino) {
            if (origemDestino)
            {
                Console.WriteLine("Digite o COD da moeda de origem: ");
            }
            else {
                Console.WriteLine("Digite o COD da moeda de destino: ");
            }

            moedaOrigemDestino = int.Parse(Console.ReadLine());
        }
        public void DesejaContinuar() {

                Console.WriteLine("Deseja continuar? (S/N)");
                string resposta = Console.ReadLine();
                if (resposta.ToUpper() != "S")
                {
                PararPrograma();
                }
        }

        public void PararPrograma()
        {
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
