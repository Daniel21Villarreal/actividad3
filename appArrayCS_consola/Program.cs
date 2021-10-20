using System;

namespace appArrayCS_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arreglo de 10 string´s
            //string[] a = new string[10]; 

            //a[0] = "algo";
            //a[1] = "aaass";
            //for (int i = 0; i < a.Length; i++)
            // {
            //a[i] = "hola" + (i + 1);
            // }
            //for  (int i =0; i < a.Length; i++)
            // {
            // Console.WriteLine(a[i]);
            // }
            Persona[] arregloPersonas = new Persona[5];
            for (int i =0;i < arregloPersonas.Length; i++)
            {
                arregloPersonas[i] = new Persona();
                arregloPersonas[i].Nombre = "";
                Console.WriteLine("INGRESA NOMBRE");
                Console.ReadLine();
                arregloPersonas[i].Apellidos = "";
                Console.WriteLine("INGRESA A´PELLIDOS");
                Console.ReadLine();
                arregloPersonas[i].FechaNacimiento = new DateTime(2003, 8, 21);
            }

            for (int i = 0; i < arregloPersonas.Length; i++)
            
                Console.WriteLine( arregloPersonas[i].ToString());

            Console.ReadKey();
        }
    }
}
