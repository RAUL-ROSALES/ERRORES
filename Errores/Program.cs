using System;
using System.Collections.Generic;

namespace Errores
{
    class Program
    {
        public static object Util { get; private set; }
        static void Main(string[] args)
        {
            var estudiante = new List<Estudiante>();
            var agregar = true;
            /*el while va a hacer la funcion de que se va a estar agregando un nuevo cada 
             estudiante cuando el usuario desee nada mas asiendole la pregunta de si desea continuar 
             o no*/
            while (agregar)
            {
                /*Si el código que está dentro del try falla, se ejecuta el catch y 
                 el programa se sigue ejecutando */
                try
                {
                    var e = new Estudiante();
                    var Ncontrol = e.Id;                
                    Console.Write("Ingrese el nombre del alumno: ");
                    e.Nombre = Console.ReadLine();
                    Console.Write("Ingrese matricula: ");
                    /*el try parse sirve para si el valor que en 
                     usuario esta ingresando es un caracter 
                     este lo trasformara en 0 
                     de lo contrario correra normal*/
                    bool result = int.TryParse(Console.ReadLine(), out Ncontrol);
                    if (Ncontrol == 0)
                    {
                        Console.WriteLine("Ingrese un numero.");
                        Console.Write("Ingrese matricula: ");
                        bool resultado = int.TryParse(Console.ReadLine(), out Ncontrol);
                    }
                    Console.Write("Ingrese la carrera: ");
                    e.Carrera = Console.ReadLine();
                    Console.Write("Ingrese el semestre que cursa: ");
                    e.Semestre = Convert.ToInt32(Console.ReadLine());
                    estudiante.Add(e);
                    Console.WriteLine("¿sea agregar un estudiante mas? si para agregra ");
                    string opc = Console.ReadLine();
                    opc = opc.ToLower();
                    //el ToLower sirve para que auque el usuiaro ingrese el si en mayusculas 
                    //el programa lo trasforme en minusculas y no lo tome como un no 
                    opc.ToLower();
                    if ( opc!= "si")
                    {
                        agregar = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ingresar el estudiante.");
                }
            }
            Console.ReadKey();
        }
    }
}
/*La sentencia para manejo de errores Try Catch en C# es utilizado en programación
 . Net para evitar romper el flujo de trabajo de una aplicación*/
/*Cuando este método regresa, contiene 
  el valor entero con signo de 32 bits equivalente al
  número contenido s, si la conversión tuvo éxito, o cero si la conversión falló. 
  La conversión falla si el sparámetro es nullo Vacío , no tiene el formato correcto o 
  representa un número menor que MinValue o mayor que MaxValue . Este parametro 
  se pasa sin inicializar; cualquier valor suministrado originalmente resultse sobrescribirá.*/

