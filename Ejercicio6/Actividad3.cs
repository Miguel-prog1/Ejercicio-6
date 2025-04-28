using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Actividad3
    {
        public static void Main(string[] args)
        {
            Jugador jugador = new Jugador("Lucas", 12, 22, 10);
            jugador.MostrarInformacion();
            jugador.SumarAntiguedad(30);
            jugador.MostrarInformacion();
            jugador.SumarAntiguedad(100, "El jugo de mas");
            jugador.MostrarInformacion();
            Jugador jugador1 = new Jugador("Jose", 22, 30, 9);
            jugador1.MostrarInformacion();
            jugador1.SumarAntiguedad(40);
            jugador1.MostrarInformacion();
            jugador1.SumarAntiguedad(100, "El por entrar entre los 10 mejores ");
            jugador1.MostrarInformacion();
            Tecnico tecnico = new Tecnico("Damian", 20, 33, "pajas");
            tecnico.MostrarInformacion();
            tecnico.SumarAntiguedad(40);
            tecnico.MostrarInformacion();
            tecnico.SumarAntiguedad(100, "por pajas");
            Tecnico tecnico1 = new Tecnico("Tobias", 30, 102, "ola");
            tecnico1.MostrarInformacion();
            tecnico1.SumarAntiguedad(103, "cuidado por tecnicatura");
            tecnico1.MostrarInformacion();
          
        }
        public class Integrante
        {
            public string nombre;
            public int edad;
            public int antiguedad;

            public Integrante (string nombre, int edad, int antiguedad)
            {
                this.nombre = nombre;
                this.edad = edad;
                this.antiguedad = antiguedad;
            }
            public int SumarAntiguedad(int anti)
            {
                if (anti > antiguedad)
                {
                    antiguedad +=  anti;                
                
                }
                else
                {
                    Console.WriteLine("El numero puesto debe de hacer mayor a la antiguedad actual");
                }
                return antiguedad;
            }
            public void SumarAntiguedad(int anti, string motivo)
            {
                SumarAntiguedad (anti);
                Console.WriteLine(motivo);
            }
            public void MostrarInformacion()
            {
                Console.WriteLine($"El nombre es {nombre}, tiene {edad} años, la antiguedad {antiguedad}"); 

            }

        }
        public class Jugador : Integrante
            
        {
            public int posicion; 
            public Jugador (string nombre, int edad, int antiguedad, int posicion) : base(nombre, edad, antiguedad)
            {
                this.posicion = posicion;
            }
            public void MostrarInformacion()

            {
                Console.WriteLine($"El nombre es {nombre}, tiene {edad} años, la antiguedad {antiguedad}, La posicion es de: {posicion} ");
            }
        }
        public class Tecnico : Integrante
        {
            public string especialidad; 
            public Tecnico (string nombre, int edad, int antiguedad, string especialidad ) : base(nombre , edad, antiguedad)
            {
                this.especialidad = especialidad;
            }
            public void MostrarInformacion()
            {
                Console.WriteLine($"El nombre es {nombre}, tiene {edad} años, la antiguedad {antiguedad},La especialidad es: {especialidad}");
            }

        }
    }
}
/*3) Crear la clase Integrante que posea nombre, edad, antigüedad y un único método constructor que
almacene los datos de las variables nombradas.
Crear dos clases hijas:
Jugador.
Tecnico.
Jugador debe tener posicion.
Tecnico debe tener especialidad.
Crear el método sumarAntiguedad(int cantidad) que incremente el valor de la antigüedad siempre
que el valor por parametro sea superior al existente.
Crear el método sumarAntiguedad(int cantidad, string motivo) para los casos en los que se
incremente la antigüedad con un mótivo especifico. El motivo solamente debe imprimirse en
pantalla.
Instanciar en el Main al menos dos objetos de la clase Jugador y dos objetos de la clase Tecnico,
ejecutar los métodos descriptos para cada tipo de Integrante y mostrar la información final por
pantalla con un método de MostrarInformación().*/