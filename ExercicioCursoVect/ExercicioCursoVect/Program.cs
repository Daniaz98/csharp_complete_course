namespace ExercicioCursoVect;

class Program
{
    static void Main(string[] args)
    {
        Alunos[] arr = new Alunos[10];

        Console.WriteLine("Quantos quartos serão alugaods?  ");
        var n = int.Parse(Console.ReadLine());

        

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Aluguel #{i}: ");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Quarto: ");
            int quarto = int.Parse(Console.ReadLine());
            arr[quarto] = new Alunos(nome, email);
        }

        Console.WriteLine();
        Console.WriteLine("Quartos ocupados: ");
        for (int i = 0; i < 10; i++)
        {
            if (arr[i] != null)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}