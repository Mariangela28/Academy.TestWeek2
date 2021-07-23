using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.TestWeek2
{
    public enum Tipo
    {
        AMEX,
        VISA,
        MASTERCARD,
        OTHER
    }
    public class CreditCardMovement : IMovement
    {
        public Tipo Tipo { get; set; }
        public int NumeroCarta { get; set; }
        public double Importo { get; set; }
        public DateTime DataMovimento { get; set; }

        public CreditCardMovement(double importo, DateTime dataMovimento, int numeroCarta, Tipo tipo)
        {
            Importo = importo;
            DataMovimento = dataMovimento;
            NumeroCarta = numeroCarta;
            Tipo = tipo;
        }
        public override string ToString()
        {
            return $"{Importo} {DataMovimento.ToShortDateString()} {Tipo} {NumeroCarta}";
        }
    }
}
