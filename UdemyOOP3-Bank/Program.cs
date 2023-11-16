using System.Globalization;
using UdemyOOP3_Bank;

Console.Write("Entre o número da conta: ");
int id = int.Parse(Console.ReadLine());
Console.Write("Entre o titular da conta: ");
string titular = Console.ReadLine();
Console.Write("Haverá deposito inicial(s/n)? ");
char op = Console.ReadLine()[0];
double movement = 0;

if (op == 's'|| op =='S') {
    Console.Write("Entre o valor de depósito inicial: ");
    movement = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

}


Console.WriteLine();
BankAccount bankAccount = new BankAccount(titular,id);
bankAccount.Deposit(movement);
Console.WriteLine("Dados da conta");
Console.WriteLine(bankAccount.ToString());
bool negativeMove = true;
Console.WriteLine();


while (negativeMove) {
    Console.Write("Entre um valor para depósito: ");
    movement = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (movement > 0) {
        negativeMove = false;
    }
}


negativeMove = true;
bankAccount.Deposit(movement);
Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(bankAccount.ToString());
Console.WriteLine();



while (negativeMove) {
    Console.Write("Entre um valor para saque: ");
    movement = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (movement > 0) {
        negativeMove = false;
    }
}

bankAccount.Withdraw(movement);
Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(bankAccount.ToString());
