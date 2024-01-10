//using System.Runtime.Intrinsics.X86;

//Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do
//titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito
//inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua
//conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.
//Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já
//o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por
//exemplo).
//Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger
//isso. O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque
//realizado, o banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo se o saldo não for
//suficiente para realizar o saque e/ou pagar a taxa.
//Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não
//informado o valor de depósito inicial. Em seguida, realizar um depósito e depois um saque, sempre
//mostrando os dados da conta após cada operação. 

using BankAccount;

int accountNumber;
string accountName;
double accountAmountValue;
char yOrN;
bool hasInitialDeposit = false;
Account account;

Console.Write("Type new account number: ");
accountNumber = int.Parse(Console.ReadLine());

Console.Write("Type account owner's name: ");
accountName = Console.ReadLine();

Console.Write("You will deposit an initial value (y/n)? ");
yOrN = char.Parse(Console.ReadLine());

if(yOrN == 'y' || yOrN == 'Y') {
    hasInitialDeposit = true;
}

Console.WriteLine();

if (hasInitialDeposit) {
    Console.Write("Type Initial value: ");
    accountAmountValue = double.Parse(Console.ReadLine());
    account = new(accountName, accountNumber, accountAmountValue);
} else {
    account = new(accountName, accountNumber);
}

Console.WriteLine();
Console.WriteLine("Account's Data:");
Console.Write(account);

Console.WriteLine();
Console.Write("Type a value to deposit: ");
accountAmountValue = double.Parse(Console.ReadLine());
account.Deposit(accountAmountValue);

Console.WriteLine();
Console.WriteLine("Updated Account's Data: ");
Console.WriteLine(account);

Console.Write("Type a value to withdraw: ");
accountAmountValue = double.Parse(Console.ReadLine());
account.WithDraw(accountAmountValue);

Console.WriteLine("Updated Account's Data: ");
Console.WriteLine(account);

//ex1

//Entre o número da conta: 8532
//Entre o titular da conta: Alex Green
//Haverá depósito inicial (s/n)? s
//Entre o valor de depósito inicial: 500.00
//Dados da conta:
//Conta 8532, Titular: Alex Green, Saldo: $ 500.00
//Entre um valor para depósito: 200.00
//Dados da conta atualizados:
//Conta 8532, Titular: Alex Green, Saldo: $ 700.00
//Entre um valor para saque: 300.00
//Dados da conta atualizados:
//Conta 8532, Titular: Alex Green, Saldo: $ 395.00

//ex2

//Entre o número da conta: 7801
//Entre o titular da conta: Maria Brown
//Haverá depósito inicial (s/n)? n
//Dados da conta:
//Conta 7801, Titular: Maria Brown, Saldo: $ 0.00
//Entre um valor para depósito: 200.00
//Dados da conta atualizados:
//Conta 7801, Titular: Maria Brown, Saldo: $ 200.00
//Entre um valor para saque: 198.00
//Dados da conta atualizados:
//Conta 7801, Titular: Maria Brown, Saldo: $ -3.00