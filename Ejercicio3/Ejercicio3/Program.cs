String nombre;
int DUI, NIT, SalarioHora, HorasTrabajadas, CantidadEmpleados = 5;
double salario;
salario = 1.13;
for (int i = 1; i <= CantidadEmpleados; i++)
{
    Console.WriteLine("Empleado " + i + ":");
    nombre = Console.ReadLine();
    Console.WriteLine("Ingrese su DUI" + ":");
    DUI = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese su Numero de NIT:");
    NIT = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad de horas trabajadas:");
    HorasTrabajadas = int.Parse(Console.ReadLine());
    salario = (HorasTrabajadas) * 1.12;
    Console.Clear();
}
Console.WriteLine("El salario del empleado es:" + salario);