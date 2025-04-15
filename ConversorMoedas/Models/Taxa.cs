using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoedas.Models
{
    public class Taxas
    {
        private readonly Double _usd = 0.1711596;
        //private readonly Double _usd = 5;
        private readonly Double _eur = 0.1506955;

        public Double GetUsd()
        {
            return _usd;
        }

        public Double GetEur()
        {
            return _eur;
        }
    }
}
