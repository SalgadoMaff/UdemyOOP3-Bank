
using System.Globalization;

namespace UdemyOOP3_Bank {
    internal class BankAccount {
        public int ID { get; private set; }
        public string Titular { get; set; }
        private double Balance { get; set; }


        
        public void Deposit(double income) {
            this.Balance += income;
        }
        public void Withdraw(double withdraw) {
            this.Balance -= withdraw;
            this.Balance -= 5;
        }

        public BankAccount(int iD) {
            ID = iD;
        }

        public BankAccount(string titular,int iD):this(iD) {
            Titular = titular;
        }

        public override string ToString() {
            return "Conta " + this.ID + $", Titular: {this.Titular}, Saldo: ${(this.Balance).ToString("F2", CultureInfo.InvariantCulture)} ";

        }
    }
}
