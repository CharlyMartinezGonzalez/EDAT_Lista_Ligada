using ListaLigada.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lista ligada simple");
        Console.WriteLine("");

        var singleList = new SingleList<String>();
        int opcion =0;
        do
        {
           opcion =  Menu();

            switch( opcion )
            {
                case 1: AgregarElemento(); break;
                case 2: MostrarLista();  break;
                case 0: break;

                default:Console.WriteLine("Esta opcion no existe"); break;

            }

        }
        while (opcion != 0);


         void AgregarElemento()
        {
            Console.WriteLine("Escribe el nombre del nodo\n");
            var data = Console.ReadLine();
            singleList.Add(data);
        }

        void MostrarLista()
        {
            Console.WriteLine("La lista es:\n");
            Console.WriteLine(singleList);
            Console.WriteLine("");
        }

        Console.ReadKey();  
    }// Aqui termina el main

    

    private static int Menu()
    {
       Console.WriteLine("MENU\n");
        Console.WriteLine("1. Agregar elemento");
        Console.WriteLine("2. Mostrar Lista");
        Console.WriteLine("3. Salir\n");

        bool esValido = false;

        int opcion = 0;

        do
        {
            Console.Write("Elije una opcion del Menu:   ");
            var opcionCapturada = Console.ReadLine();

            if (!int.TryParse(opcionCapturada,out opcion)|| opcion < 0 || opcion > 2)
            {
                Console.WriteLine("Ingrese una opcion valida");
                esValido = false;
            }
            else
            {
                esValido= true;
            }

        }
        while (esValido==false);

        return opcion;


    }
}