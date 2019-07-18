using System;

namespace Practica_Num1.Ejercicios
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            //Variables
            string nombre;
            string apellido;
            string cargo;
            string correo;
            int edad;
            int dia;
            int mes;
            int anio;
            string fechaContratacion;
            sbyte sueldo;

            //Proceso: Introdccuion
            Console.WriteLine("Recolección de datos de empleados");
            Console.WriteLine("Presione [Enter] para continuar");
            Console.ReadLine();


            //Proceso: Recoleccion de datos
            Console.Clear();
            //Nombre
            Console.WriteLine("Escriba el nombre del empleado:");
            nombre = Console.ReadLine();
            Console.WriteLine();
            //Apellido
            Console.WriteLine("Apellido:");
            apellido = Console.ReadLine();
            Console.WriteLine();
            //Cargo
            Console.WriteLine("Cargo del empleado:");
            Console.WriteLine();
            cargo = Console.ReadLine();
            //Edad
            Console.WriteLine("Edad del empleado:");
            edad = Convert.ToInt32(Console.ReadLine());
            //Correo
            Console.WriteLine("Correo del empleado:");
            correo = Console.ReadLine();
            //Fecha
            Console.WriteLine("Fecha de Contratación");
            Console.Write("Dia:");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mes:");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Año");
            anio = Convert.ToInt32(Console.ReadLine());
        }
    }
}
