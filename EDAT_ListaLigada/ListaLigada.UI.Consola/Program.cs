using ListaLigada.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("");

        var singleList = new SingleList<string>();
        singleList.Add("Alondra");
        singleList.Add("Karla");
        singleList.Add("Luis");
        singleList.Add("Zapato");
        singleList.Add("Apaneca");
        singleList.Add("Pedro");

        Console.WriteLine(singleList);

        Console.ReadKey();
    }
}