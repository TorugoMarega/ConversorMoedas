using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoedas.Models
{
    public class Moeda
    {
        public String Nome { get; set; }
        public String Simbolo { get; set; }
        public Double TaxaConversao { get; set; }
    }
}
