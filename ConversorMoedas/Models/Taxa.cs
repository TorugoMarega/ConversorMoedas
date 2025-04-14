using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoedas.Models
{
    class Taxas
    {
        private Double _usd = 0.1711596;
        private Double _eur = 0.1506955;

        public Double getUsd()
        {
            return _usd;
        }

        public Double getEur()
        {
            return _eur;
        }
    }
}
