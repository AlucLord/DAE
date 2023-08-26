namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Por favor ingrese un numero: ");
            numero=int.Parse(Console.ReadLine());

            if (numero == 10) 
            {
                Console.WriteLine("El numero ingresado es 10");
            }else if (numero == 15)
            {
                Console.WriteLine("El numero ingresado es 15");
            }else if(numero == 20)
            {
                Console.WriteLine("El numero ingresado es 20");
            }else { Console.WriteLine("El numero ingresado no se encuentra en el rango de evaluacion"); }

            Console.ReadKey();//es para presionar una tecla y que termine la ejecucion del codigo
        }
    }
}