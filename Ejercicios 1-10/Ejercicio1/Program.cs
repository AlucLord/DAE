namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingreso de 4 numeros");
            Console.WriteLine("Suma de los 2 primeros");
            Console.WriteLine("------------------------");
            int numero1;
            Console.WriteLine("Ingrese el primer numero: ");
            numero1 = int.Parse(Console.ReadLine());
            int numero2;
            Console.WriteLine("Ingrese el segundo numero:");
            numero2 = int.Parse(Console.ReadLine());
            int suma=numero1 + numero2;
            Console.WriteLine("La suma del primero y segundo numero es: " + suma);

            Console.WriteLine("Producto de dos numeros");
            int numero3;
            Console.WriteLine("Ingrese el tercer numero: ");
            numero3 = int.Parse(Console.ReadLine());
            int numero4;
            Console.WriteLine("Ingrese el cuarto numero: ");
            numero4 = int.Parse(Console.ReadLine());
            int producto = numero3 * numero4;

            Console.WriteLine("El producto del tercer y cuarto numero es: " + producto);
        }
    }
}