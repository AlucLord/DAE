namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determinar si es numero primo");
            int n = 0;
            int c = 0;
            Console.WriteLine("Ingrese un numero para determinar si es primo o no");
            n=Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i < (n+1); i++)
            {
                if (n%i == 0)
                {
                    c++;
                }
            }
            if (c != 2)
            {
                Console.WriteLine("El numero no es primo");
            }
            else
            {
                Console.WriteLine("El numero es primo");
            }

            Console.ReadKey();
        }
    }
}