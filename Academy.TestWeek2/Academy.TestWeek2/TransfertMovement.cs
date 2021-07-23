using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.TestWeek2
{
    public class TransfertMovement : IMovement
    {
        public string BancaOrigine { get; set; }
        public string BancaDestinazione { get; set; }
        public double Importo { get; set; }
        public DateTime DataMovimento { get; set; }

        public TransfertMovement(double importo, DateTime dataMovimento, string bancaOrigine, string bancaDestinazione)
        {
            Importo = importo;
            DataMovimento = dataMovimento;
            BancaOrigine = bancaOrigine;
            BancaDestinazione = bancaDestinazione;
        }
        public override string ToString()
        {
            return $"{Importo} {DataMovimento.ToShortDateString()} {BancaOrigine} {BancaDestinazione}";
        }
    }
}
