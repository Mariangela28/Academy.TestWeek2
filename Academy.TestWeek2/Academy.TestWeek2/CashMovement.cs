using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.TestWeek2
{
    public class CashMovement : IMovement
    {
        public string Esecutore { get; set; }
        public double Importo { get; set; }
        public DateTime DataMovimento { get; set; }

        public CashMovement(double importo, DateTime dataMovimento, string esecutore)
        {
            Importo = importo;
            DataMovimento = dataMovimento;
            Esecutore = esecutore;
        }

        public override string ToString()
        {
            return $"{Importo} {DataMovimento.ToShortDateString()} {Esecutore}";
        }
    }
}
