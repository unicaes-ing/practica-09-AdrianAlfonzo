using System;
using System.Collections.Generic;

namespace Ejercicio1Guia9
{
    //------------------UNICAES------------------
    //---Facultad de Ingenería y Arquitectura---
    //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
    //-Última fecha de modificación: 11.10.19
    //-------Luis Adrián Alfonzo Morán-------
    class Program
    {
        //Lista
        static List<string> Fruits = new List<string>();
        //Main
        static void Main(string[] args)
        {
            Menu();
        }
        //Menu
        static void Menu()
        {
            //Base
            int opt;
            //Mostrar
            Console.WriteLine("Opción [1]: Agregar a la lista");
            Console.WriteLine("Opción [2]: Mostrar la lista");
            Console.WriteLine("Opción [3]: Insertar en la lista");
            Console.WriteLine("Opción [4]: Eliminar de la lista");
            Console.WriteLine("Opción [5]: Buscar en la lista");
            Console.WriteLine("Opción [6]: Vaciar lista");
            Console.WriteLine("Opción [7]: Salir");
            opt = Int32.Parse(Console.ReadLine());
            //Función en SWITCH
            switch (opt)
            {
                //Agregar fruta
                case 1:
                    Console.Clear();
                    AddFruit();
                    break;
                //Mostrar frutas
                case 2:
                    Console.Clear();
                    ShowFruit();
                    break;
                //Insertar frutas
                case 3:
                    Console.Clear();
                    InsertFruit();
                    break;
                //Eliminar frutas
                case 4:
                    Console.Clear();
                    EliminateFruit();
                    break;
                //Buscar frutas
                case 5:
                    Console.Clear();
                    FindFruit();
                    break;
                //Limpiar frutas
                case 6:
                    Console.Clear();
                    ClearFruit();
                    break;
                //Salir
                case 7:
                    Console.Clear();
                    Exit();
                    break;
                default:
                    break;
            }
        }
        //Funcion agregar frutas
        static void AddFruit()
        {
            //Base
            string fruit;
            Console.Clear();
            //Consulta
            Console.WriteLine("¿Cuántas frutas desea agregar a la lista?");
            int how = Convert.ToInt32(Console.ReadLine());
            int[] add = new int[how];
            //Proceso en FOR
            for (int i = 0; i < add.Length; i++)
            {
                Console.Write("Fruta: ");
                fruit = Console.ReadLine();
                Fruits.Add(fruit);
            }
            Console.Clear();
            //Proceso en FOREACH
            foreach (string fru in Fruits)
            {
                Console.WriteLine(fru);
            }
            Console.Clear();
            Menu();
        }
        //Funcion mostrar frutas
        static void ShowFruit()
        {
            //Base
            int count = 1;
            //Proceso en FOREACH
            foreach (var item in Fruits)
            {
                Console.WriteLine($"Fruta [{count}]: {item}");
                count++;
            }
            Console.ReadKey();
            Menu();
        }
        //Funcion insertar frutas
        static void InsertFruit()
        {
            Console.Clear();
            //Base
            int numberOne;
            string add;
            //Consulta
            Console.WriteLine("¿En que posición está la fruta que desea insertar?");
            numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Cuál es la nueva fruta que desea insertar?");
            add = Console.ReadLine();
            Fruits.Insert(numberOne, add);
            Console.Clear();
            //Proceso en FOREACH
            foreach (string fru in Fruits)
            {
                Console.WriteLine(fru);
            }
            Menu();
        }
        //funcion eliminar frutas
        static void EliminateFruit()
        {
            Console.Clear();
            //Base
            int numberOne;
            //Consulta
            Console.WriteLine("¿En que posición está la fruta que desea eliminar?");
            numberOne = Convert.ToInt32(Console.ReadLine());
            Fruits.RemoveAt(numberOne);
            Console.Clear();
            //Proceso en FOREACH
            foreach (string fru in Fruits)
            {
                Console.WriteLine(fru);
            }
            Menu();
        }
        //Funcion buscar frutas
        static void FindFruit()
        {
            Console.Clear();
            //Base
            string find;
            //Consulta
            Console.WriteLine("Ingrese la fruta que desea buscar");
            find = Console.ReadLine();
            //Proceso en DO
            do
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("La fruta sí está en la lista");
            } while ((Fruits.Contains(find)));
            Console.ResetColor();
            Menu();
        }
        //funcion limpiar frutas
        static void ClearFruit()
        {
            Console.Clear();
            Fruits.Clear();
            Menu();
        }
        //Funcion salir
        static void Exit()
        {
            Console.Clear();
            Environment.Exit(0);
        }
    }
}
