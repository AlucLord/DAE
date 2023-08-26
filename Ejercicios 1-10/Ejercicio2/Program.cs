namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float precio;
            Console.WriteLine("Ingrese el precio del articulo: ");
            precio = float.Parse(Console.ReadLine());//por si lleva fraccion c:

            int articulo;
            Console.WriteLine("Ingrese la cantidad de articulos que desea comprar: ");
            articulo = int.Parse(Console.ReadLine());

            float total = articulo * precio;
            Console.WriteLine("La cantidad total a pagar es: " + total);
        }
    }
}