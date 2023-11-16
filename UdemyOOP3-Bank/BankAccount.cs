
namespace UdemyOOP3_Bank {
    internal class BankAccount {
        private int _id;
        public string Titular { get; set; }
        public double Balance { get; set; }

        public void SetId(int id) {
            this._id = id;
        }

        public void Deposit(double income) {
            this.Balance += income;
        }
        public void Withdraw(double withdraw) {
            this.Balance -= withdraw;
            this.Balance -= 5;
        }

    }
}
