namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool bandera1 = false, bandera2=false;
            int n1, n2, sumaTotal = 0;
            Console.WriteLine("Ingrese el valor de N1");
            n1= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el valor de N2");
            n2= int.Parse(Console.ReadLine());

            if (n1>=0 && n1<n2)
            {
                bandera1 = true;
            }
            else
            {
                Console.WriteLine("Dato incorrecto para N1");
            }
            if (n2 > n1)
            {
                bandera2 = true;
            }
            else
            {
                Console.WriteLine("Dato incorrecto para N2");
            }

            if (bandera1 && bandera2)
            {
                for (int i = n1; i <= n2; i++)
                {
                    if (i % 2 == 0)
                     {
                        sumaTotal = sumaTotal + i;
                     }
                    Console.WriteLine("La suma de los numeros pares en el rango son: " + sumaTotal);
                }
            }

        }
    }
}