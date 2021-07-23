using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.TestWeek2
{
    public  class OperazioniAccount
    {
        public string Nome { get; set; }
        public List<Account> Account { get; set; }
        public List<TransfertMovement> transfertMovements { get; set; }
        public OperazioniAccount(string Nome)
        {
            this.Nome = Nome;
            this.Account = new List<Account>();
        }

        internal static bool Menu()
        {
            Console.WriteLine("Benvenuto");
            Console.WriteLine("1. Crea un account");
            Console.WriteLine("2. Inserisci un movimento");
            Console.WriteLine("3. Stampa i dati del conto e i movimenti");
            Console.WriteLine("4. Esci");
            int scelta = Helper.VerificaInput(4); //da fare!!!
            GestisciScelta(scelta);
            return scelta > 0 && scelta < 4;
        }

        private static void GestisciScelta(int scelta)
        {
            switch (scelta)
            {
                case 1: 
                    AddAccount();
                    break;
                case 2:
                    Movements();
                    break;
                case 3:
                    StampaDati(numeroConto, nomeBanca, saldo, ultimaOperazione);
                    break;
                default:
                    Console.WriteLine("Arrivederci");
                    break;

            }
        }

        

        

        private static void StampaDati(string numeroConto, string nomeBanca, double saldo, DateTime ultimaOperazione)
        {
            Console.WriteLine("*** Estratto conto ***");
            Console.WriteLine("");
            Console.WriteLine("Numero conto: {0}", numeroConto);
            Console.WriteLine("Nome banca: {0}", nomeBanca);
            Console.WriteLine("Saldo: {0} euro ", saldo);
            Console.WriteLine("Data ultima operazione: ", ultimaOperazione);
            Console.WriteLine("");
        }

        public void AddAccount(Account Account)
        {
            this.Account.Add(Account);
        }
        public void Movimenti(TransfertMovement transfertMovement)
        {
            this.TransfertMovements.Add(transfertMovement);
        }


    }

    
}
