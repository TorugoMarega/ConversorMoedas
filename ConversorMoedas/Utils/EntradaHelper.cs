using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoedas.Utils
{
    public class EntradaHelper
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

        public int LerMoeda(bool origemDestino, ref int moeda, int index)
        {
            if (origemDestino)
                Console.WriteLine("\nDigite o COD da moeda de origem: ");
            else
                Console.WriteLine("\nDigite o COD da moeda de destino: ");

            if (!int.TryParse(Console.ReadLine(), out int codigo))
            {
                Console.WriteLine("\nEntrada inválida. Tente novamente.");
                return LerMoeda(origemDestino, ref moeda, index);
            }

            // Validação das regras
            bool entradaInvalida =
                codigo > index ||
                (origemDestino && codigo > 0) ||    // moeda de origem deve ser 0
                (!origemDestino && codigo < 1);     // moeda de destino não pode ser 0

            if (entradaInvalida)
            {
                Console.WriteLine("\nOpção inválida. Tente novamente.");
                return LerMoeda(origemDestino, ref moeda, index);
            }

            moeda = codigo;
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
