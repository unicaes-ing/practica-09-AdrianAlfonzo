using System;
using System.Collections.Generic;

namespace Ejercicio1Guia9
{
    //------------------UNICAES------------------
    //---Facultad de Ingenería y Arquitectura---
    //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
    //-Última fecha de modificación: 11.10.19
    //-------Luis Adrián Alfonzo Morán-------
    class Ejercicio2Guia9
    {
        //Estructura
        public struct Students
        {
            public string ID;
            public string name;
            public string run;
            private double cum;
            //Getter
            public double GetCum()
            {
                return cum;
            }
            //Setter
            public void SetCum(double cum)
            {
                if (cum >= 0)
                {
                    if (cum <= 10)
                    {
                        this.cum = cum;
                    }
                }
            }
        }
        //Main
        static void Main(string[] args)
        {
            //Diccionario
            Dictionary<string, Students> data = new Dictionary<string, Students>();
            //Base
            int opt;
            //Consulta
            Conector:
            Console.WriteLine("Opción [1] Agregar estudiante a la lista");
            Console.WriteLine("Opción [2] Mostrar estudiantes de la lista");
            Console.WriteLine("Opción [3] Eliminar estudiantes de la lista ");
            Console.WriteLine("Opción [4] Buscar estudiantes en la lista ");
            Console.WriteLine("Opción [6] Limpiar diccionario");
            Console.WriteLine("Opción [7] Salir");
            opt = Convert.ToInt32(Console.ReadLine());
            //Base
            int how;
            //Proceso en SWITCH
            switch (opt)
            {
                //Agregar estudiante
                case 1:
                    Console.Clear();
                    //Consulta
                    Console.WriteLine("¿Cuántos estudiantes se analizarán?");
                    how = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    //Proceso en FOR
                    for (int i = 0; i < how; i++)
                    {
                        Students newStud = new Students();
                        Console.WriteLine("Estudiante #{0}", i + 1);
                        //Proceso en DO
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("¿Cuál es el carnet del estudiante {0}?", i + 1);
                            newStud.ID = Console.ReadLine();
                            //Proceso en IF
                            if (data.ContainsKey(newStud.ID))
                            {
                                Console.WriteLine("El carnet {0} ya fue ingresado", newStud.ID);
                            }
                        } while (data.ContainsKey(newStud.ID));
                        Console.WriteLine("¿Cuál es el nombre completo del estudiante?");
                        newStud.name = Console.ReadLine();
                        Console.WriteLine("¿Que carrera está estudiando actuamente?");
                        newStud.run = Console.ReadLine();
                        Console.WriteLine("¿Cuál es el CUM del estudiante?");
                        newStud.SetCum(Convert.ToDouble(Console.ReadLine()));
                        data.Add(newStud.ID, newStud);
                    }
                    Console.Clear();
                    goto Conector;
                //Mostrar estudiante
                case 2:
                    Console.Clear();
                    //Proceso en FOREACH
                    foreach (KeyValuePair<string, Students> datos in data)
                    {
                        Console.WriteLine(datos);
                    }
                    break;
                //Eliminar estudiante
                case 3:
                    Console.Clear();
                    //Base
                    string eliminate;
                    //Consulta
                    Console.WriteLine("¿Cuál es el carnet o identificador estudiantil que desea eliminar?");
                    eliminate = Console.ReadLine();
                    data.Remove(eliminate);
                    //Proceso en FOREACH
                    foreach (KeyValuePair<string, Students> datos in data)
                    {
                        Console.WriteLine(datos);
                    }
                    break;
                //Buscar alumno
                case 4:
                    Console.Clear();
                    //Base
                    string find;
                    //Consulta
                    Console.WriteLine("¿Cuál es el nombre del estudiante que desea buscar?");
                    find = Console.ReadLine();
                    //Proceso en DO
                    do
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("El estudiante si está en la lista");
                    } while ((data.ContainsKey(find)));
                    Console.ResetColor();
                    break;
                //Vaciar diccionario
                case 5:
                    Console.Clear();
                    data.Clear();
                    break;
                //Salir
                case 6:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
