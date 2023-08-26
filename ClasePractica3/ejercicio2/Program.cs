namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool bandera = true;

            while (bandera)
            {
                int opcion;
                Console.WriteLine("Bienvenido al menu");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Actualizar");
                Console.WriteLine("3. Eliminar");
                Console.WriteLine("4. Buscar");
                Console.WriteLine("5. Salir del sistema");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Dato ingregsado");
                        break;
                    case 2:
                        Console.WriteLine("Dato actualizado");
                        break;
                    case 3:
                        Console.WriteLine("Dato eliminado");
                        break;
                    case 4:
                        Console.WriteLine("Busqueda de dato");
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del sistema");
                        bandera = false;
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
                
            }
        }
    }
}