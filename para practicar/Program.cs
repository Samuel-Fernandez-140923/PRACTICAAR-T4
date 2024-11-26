
using para_practicar;
using static para_practicar.Datos;

internal class Program
{
    private static void Main(string[] args)
    {
        int respuesta = 1;
        int r2;
        Datos datos = new Datos();

        do
        {
            Console.Write("Cuantos datos ingresar: ");
            respuesta = int.Parse(Console.ReadLine());
                        
        } while (respuesta <= 0);
        string[] Nombre = new string[respuesta];
        int[] Edad = new int[respuesta];
        double[] Tamaño = new double[respuesta];

        int posicion = 0;



        do
        {
            Console.WriteLine("");
            Console.WriteLine("\n**MENU**");
            Console.WriteLine("CREAR [1]: ");

            Console.Write("\n¿Que opcion quieres ingresar?: ");
            r2 = int.Parse(Console.ReadLine());

            switch (r2)
            {
                case 1:
                    for (int i = 0; i < respuesta; i++)
                    {
                        Console.WriteLine("\n*********DATOS**   *******");
                        Console.Write("INGRESA NOMBRE: ");
                        datos.Nombre = Console.ReadLine();
                        Nombre[posicion] = datos.Nombre;                
                        Console.WriteLine("IGRESA LA EDAD:");
                        datos.Edad = int.Parse(Console.ReadLine());
                        Edad[posicion]=datos.Edad;
                        Console.WriteLine("IGRESA EL TAMAÑO:");
                        datos.Tamaño = double.Parse(Console.ReadLine());
                        Tamaño[posicion] = datos.Tamaño;

                        posicion++;
                    }
                    break;

            }

        } while (r2 != 2);
    }
}

