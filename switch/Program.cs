namespace {switch;

internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Por favor ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 10:
                    Console.WriteLine("El numero ingresado es 10");
                    break;
                case 15:
                    Console.WriteLine("El numero ingresado es 15");
                    break;
                case 20:
                    Console.WriteLine("El numero ingresado es 20");
                    break;
                default:
                    Console.WriteLine("EL numero ingresado no esta dentro del rango de evaluacion");
                    break;
            }
            Console.ReadKey();
        }
    }
}