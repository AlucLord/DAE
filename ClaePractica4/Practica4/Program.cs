namespace Practica4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadEstudiantes;
            double promedio, sumaCalificaciones = 0;

            //Areglo
            Console.WriteLine("Ingrese la cantidad de estudiantes: ");
            cantidadEstudiantes = int.Parse(Console.ReadLine());

            double[] notasEstudiantes = new double[cantidadEstudiantes];

            for (int i = 0; i < notasEstudiantes.Length; i++) 
            {
                Console.WriteLine("Ingrese la nota del alumno " + (i + 1));
                notasEstudiantes[i]= double.Parse(Console.ReadLine());
            }

            for (int y = 0; y < cantidadEstudiantes; y++)
            {
                sumaCalificaciones = sumaCalificaciones + notasEstudiantes[y];
            }
            promedio = sumaCalificaciones / cantidadEstudiantes;
            Console.WriteLine("El promedio de notas es: " + promedio);
        }
    }
}