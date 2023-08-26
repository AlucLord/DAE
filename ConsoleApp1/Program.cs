namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sentencias de seleccion if simple, multiple, anidado, switch, for, while
            //Evaluar si un numero es igual a 15
            int numero;
            Console.WriteLine("Por favor ingrese un numero: ");
            numero=int.Parse(Console.ReadLine());

            if (numero==15)
            {
                Console.WriteLine("El numero ingresado es igual a 15");
            }
            else 
            {
                Console.WriteLine("El numero ingresado NO es igual a 15");
            }
            Console.ReadKey();
        }
    }
}