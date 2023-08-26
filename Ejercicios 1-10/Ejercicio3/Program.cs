namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Par o Impar");
            int numero;
            Console.WriteLine("Ingrese un numero");
            numero= int.Parse(Console.ReadLine());

            if (numero %2 == 0) 
            {
                Console.WriteLine("El numero es Par");
            }
            else 
            {
                Console.WriteLine("El numero es Impar");
            }
        }
    }
}