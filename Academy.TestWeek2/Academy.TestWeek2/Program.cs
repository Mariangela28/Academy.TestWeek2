using System;

namespace Academy.TestWeek2
{
    class Program
    {
        static void Main(string[] args)
        {

            Account account = new("123FG5GH", "Sella", 1200.00, DateTime.Now, new CreditCardMovement(134.00, DateTime.Now, 123456, Tipo.AMEX));


            bool continua = true;
            while (continua)
            {
                continua = OperazioniAccount.Menu();
            }
        }
    }
}
