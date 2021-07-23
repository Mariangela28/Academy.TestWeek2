using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.TestWeek2
{
    public class Account
    {
        public string NumeroConto { get; set; }
        public string NomeBanca { get; set; }
        public double Saldo { get; set; }
        public DateTime UltimaOperazione { get; set; }
        

        public IMovement Movement { get; set; }

        public Account(string numeroConto, string nomeBanca, double saldo, DateTime ultimaOperazione, IMovement movement)
        {
            NumeroConto = numeroConto;
            NomeBanca = nomeBanca;
            Saldo = saldo;
            UltimaOperazione = ultimaOperazione;
            Movement = movement;
        }

        public override string ToString()
        {
            return $"{NumeroConto} {NomeBanca} {Saldo} {UltimaOperazione.ToShortDateString()}";
        }



        public static bool operator +(Account account, double importo)
        {
            if (importo > 0)
            {
                account.Saldo += importo;
                
                
                return true;
            }
            return false;
        }
        public static bool operator +(Account account, DateTime date)
        {
            if (date > account.UltimaOperazione)
            {
                account.UltimaOperazione = date;


                return true;
            }
            return false;
        }

        public static bool operator -(Account account, double importo)
        {
            if (importo > 0)
            {
                account.Saldo -= importo;

                return true;
            }
            return false;
        }

        public static bool operator -(Account account, DateTime date)
        {
            if (date > account.UltimaOperazione)
            {
                account.UltimaOperazione = date;


                return true;
            }
            return false;
        }
    }
}
