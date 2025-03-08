namespace ClassExerciseUdemCourse;

public class Account
{
    public string AccountNumber { get; private set; }
    public string Titular { get; set; }
    public double InitialBalance { get; private set; }

    public Account(string accountNumber, string titular)
    {
        AccountNumber = accountNumber;
        Titular = titular;
    }

    public Account(string accountNumber, string titular, double initialBalance = 0.0) : this(accountNumber, titular)
    {
        InitialBalance = initialBalance;
    }

    public void Deposit(double valor)
    {
        if (valor > 0)
        {
            InitialBalance += valor;
            Console.WriteLine($"Depósito de R$ {valor} realizado com sucesso.");
        }
        else
        {
            Console.WriteLine("Valor inválido!");
        }
    }

    public void Withdraw(double valor)
    {
        if (valor > 0)
        {
            InitialBalance -= valor + 5;
            Console.WriteLine($"Valor de R$ {valor} retirado com sucesso.");
        }
        else
        {
            Console.WriteLine("Falha ao retirar valor!");
        }
    }

    public void DataView()
    {
        Console.WriteLine($"Dados da conta: \nTitular: {Titular} \nConta: {AccountNumber} \nSaldo: R$ {InitialBalance}");
    }
    
}