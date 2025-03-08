// See https://aka.ms/new-console-template for more information


using ClassExerciseUdemCourse;

Console.WriteLine("Seja bem-vindo ao DragonBank!");

Console.WriteLine("Entre o número da conta: ");
string accountNumber = (Console.ReadLine());

Console.WriteLine("Entre o titular da conta: ");
string titular = Console.ReadLine();

Console.WriteLine("Haverá depósito inicial? (s/n) ");
string response = Console.ReadLine().Trim().ToLower();

Account conta;

if (response.Equals("s"))
{
    Console.WriteLine("Digite o valor para depósito inicial: ");
    double dep = double.Parse(Console.ReadLine());
    conta = new Account(accountNumber, titular, dep);
}
else
{
    conta = new Account(accountNumber, titular);
}

conta.DataView();

Console.WriteLine("------------------------------------------------------");

Console.WriteLine("Entre um valor para depósito: ");
double deposit = double.Parse(Console.ReadLine());
conta.Deposit(deposit);

Console.WriteLine("------------------------------------------------------");
Console.WriteLine("Dados atualizados com sucesso!");
conta.DataView();

Console.WriteLine("------------------------------------------------------");
Console.WriteLine("Entre um valor para saque: ");
double withdraw = double.Parse(Console.ReadLine());
conta.Withdraw(withdraw);

Console.WriteLine("------------------------------------------------------");

Console.WriteLine("Dados atualizados com sucesso!");
conta.DataView();