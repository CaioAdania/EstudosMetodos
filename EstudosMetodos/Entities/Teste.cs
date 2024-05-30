using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosMetodos.Entities
{
    internal class Teste
    {
        public string Time;
        public double GolsFeitos;
        public double GolsSofridos;

        public double SaldoDeGols()
        {
            double saldo = GolsFeitos - GolsSofridos;
            return saldo;
        }
    }
}
