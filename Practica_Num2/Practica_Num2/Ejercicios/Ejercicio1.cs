﻿using System;


namespace Practica_Num2
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            //Variables
            string nombre;

            //Proceso
            Console.Write("Por favor, escriba su nombre: ");
            nombre = Console.ReadLine();
            nombre = nombre.Replace('A', '#').Replace('E', '%').Replace('I', '$').Replace('O', '?').Replace('U', '*');
            nombre = nombre.Replace('a', '#').Replace('e', '%').Replace('i', '$').Replace('o', '?').Replace('u', '*');
            Console.WriteLine(nombre);
            Console.ReadKey();

        }
    }
}
