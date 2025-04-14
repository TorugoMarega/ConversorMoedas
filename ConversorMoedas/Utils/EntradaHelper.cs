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
            Console.WriteLine("\nDigite o valor a ser convertido:");
            if (double.TryParse(Console.ReadLine(), out double valor))
            {
                return valor;
            }
            else
            {
                Console.WriteLine("\nValor inválido. Tente novamente.");
                return LerValorMonetario();
            }
        }

        public int LerMoeda(Boolean origemDestino, ref int moeda, int index) {
            if (origemDestino)
            {
                Console.WriteLine("\nDigite o COD da moeda de origem: ");
            }
            else {
                Console.WriteLine("\nDigite o COD da moeda de destino: ");
            }
            moeda = int.Parse(Console.ReadLine());

            if (moeda > index || origemDestino && moeda > 0 || !origemDestino && moeda < 1)
            {
                Console.WriteLine("\nOpção inválida. Tente novamente.");
                LerMoeda(origemDestino, ref moeda, index);
            }
            return moeda;
        }
        public void DesejaContinuar(ref bool op) {

                Console.WriteLine("\nDeseja continuar? (S/N)");
                string resposta = Console.ReadLine();
                Console.WriteLine("--------------------------\n");
            if (resposta.ToUpper() != "S")
                {
                    PararPrograma(ref op);
                }
        }

        public void PararPrograma(ref bool op)
        {
            op = false;
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
