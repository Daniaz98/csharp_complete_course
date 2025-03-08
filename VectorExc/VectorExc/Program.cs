namespace VectorExc;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a quantidade de linhas: ");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de colunas: ");
        int M = int.Parse(Console.ReadLine());

        int[,] mat = new int[N, M];

        for (int i = 0; i < N; i++)
        {
             string[] values = Console.ReadLine().Split(" ");
             for (int j = 0; j < M; j++)            
             {
                mat[i, j] = int.Parse(values[j]);
             }
        }

        Console.WriteLine("Insira um número da matriz: ");
        if (int.TryParse(Console.ReadLine(), out int X))
        {
           int linha = -1, coluna = -1;
           for (int i = 0; i < N; i++)
           {
               for (int j = 0; j < M; j++)
               {
                   if (mat[i, j] == X)
                   {
                       linha = i;
                       coluna = j;
                       break;
                   }
               }
           }

           if (coluna > 0)
           {
               int esquerda = mat[linha, coluna - 1];
               Console.WriteLine($"Elemento à esquerda: {esquerda}");
           }
           else
           {
               Console.WriteLine("Não há elemento");
           }
           
           if (coluna < M - 1)
           {
               int direita = mat[linha, coluna + 1];
               Console.WriteLine($"Elemento à direita: {direita}");
           }
           else
           {
               Console.WriteLine("Não há elemento");
           }

           if (linha > 0)
           {
               int acima = mat[linha - 1, coluna];
               Console.WriteLine($"Elemento acima: {acima}");
           }
           else
           {
               Console.WriteLine("Não há elemento");
           }


           if (linha < N - 1)
           {
               int abaixo = mat[linha + 1, coluna];
               Console.WriteLine($"Elemento abaixo: {abaixo}");
           } 
           else
           {
               Console.WriteLine("Não há elemento");
           }
        }
       
            
        


    }
}