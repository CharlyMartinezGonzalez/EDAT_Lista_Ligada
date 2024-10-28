using ListaLigada.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!, Lista ligada simple");
        Console.WriteLine("");

        var singleList = new SingleList<String>();

        singleList.Add("Alondra");
        singleList.Add("Maria");
        singleList.Add("Juan");
        singleList.Add("Luis");
        singleList.Add("Jose");

        Console.WriteLine(singleList);

        Console.ReadKey();  
    }
}