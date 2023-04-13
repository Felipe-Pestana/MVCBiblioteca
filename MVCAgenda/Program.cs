using Controllers;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Estante Virtual");

        Console.WriteLine("Informe o nome do livro:");
        string t = Console.ReadLine();
        Console.WriteLine("Informe o nome do autor: ");
        string a = Console.ReadLine();

        new BookController().InsertBook(t, a);
    }
}