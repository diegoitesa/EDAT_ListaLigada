using ListaLigada.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        var singleList = new SingleList<string>();

        int opcion = 0;

        do
        {
            opcion = Menu();

            switch (opcion)
            {
                case 0: break;
                case 1: AddItem(singleList); break;
                case 2: ShowList(singleList); break;
                
                
                default: Console.WriteLine("Esta opción no existe"); break;
                    
            }
        }
        while(opcion != 0);

        Console.ReadKey();
    }//Termina el Main

    private static void ShowList(SingleList<string> item)
    {
        Console.WriteLine("\n><><><><><><><><><><><><><><>");
        Console.WriteLine("\nLa lista es: \n");
        Console.WriteLine(item);
        Console.WriteLine("><><><><><><><><><><><><><><>\n");
    }

    private static void AddItem(SingleList<string> item)
    {
        Console.Write("\nNodo: ");
        var data = Console.ReadLine();
        item.Add(data);
        Console.Write("\n");

    }

    private static int Menu()
    {
        Console.WriteLine("MENU\n");
        Console.WriteLine("----------------------------");
        Console.WriteLine("1. Agregar elemento\n");
        Console.WriteLine("2. Mostrar lista\n");
        Console.WriteLine("0. Salir\n");
        Console.WriteLine("----------------------------");

        bool esValido = false;

        int opcion = 0;

        do
        {
            Console.Write("|> ");
            var opcionCap = Console.ReadLine();

            if (!int.TryParse(opcionCap,out opcion) || opcion < 0 || opcion > 2)
            {
                Console.WriteLine("Digite una opción válida");
                esValido = false;
            }
            else
            {
                esValido = true; 
            }
            
            
        }
        while(!esValido);

        return opcion;
    }
}