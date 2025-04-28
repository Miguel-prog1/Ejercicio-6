using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Actividad2
    {
        public static void Main2(string[] args)
        {
            Persona persona = new Persona("lucas",21,29292929);
            persona.MostrarInformacion();
            Persona persona1 = new Persona("luciano", 12);
            persona1.MostrarInformacion();
            Persona persona2 = new Persona();
            persona2.MostrarInformacion();
            
        }
        public class Persona
        {
            public string nombre;
            private int edad;
            public int dni;

            public Persona()
            {

            }
            public Persona( string nombre, int edad)
            {
                this.nombre = nombre;
                this.edad = edad;
            }
            public Persona(string nombre, int edad, int dni)
            {
                this.nombre = nombre;
                this.edad = edad;
                this.dni = dni;
            }
            public void MostrarInformacion()
            {
                Console.WriteLine($"El nombre de la  persona es: {nombre}, la edad es: {edad} y el dni es: {dni}");
            }
        }
    }
}
/* 2) Crear la clase Persona con los siguientes atributos:
nombre
private edad
DNI
Método:
MostrarInformación() que imprima por consola los tres atributos.
Crear 3 constructores:
Uno vacío.
Uno que reciba por parametro el nombre y la edad.
Uno que reciba el nombre, la edad y el DNI.
En el Main:
Crear tres objetos de Persona usando los distintos constructores y mostrar los valores de sus
propiedades con el método MostrarInformación().*/