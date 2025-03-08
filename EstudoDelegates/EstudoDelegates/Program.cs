// See https://aka.ms/new-console-template for more information

using EstudoDelegates;





internal class Program
{
    public delegate void MyDelegate(string message);

    public static void Main(string[] args)
    {
        var example = new Example();

        MyDelegate del = example.ShowMessage();
    }
}