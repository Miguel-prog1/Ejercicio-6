using System;


namespace ejercicio6
{
    class Actividad1
    {
        public static void Main1(string[] args)
        {
            Auto auto = new Auto();
            auto.marca = "Ferrari";
            auto.modelo = "Ferrari F40";
            auto.anio = 1987;
            auto.CantidadPuerta = 2;
            auto.EsAutomatico = true;
            auto.MostrarInformacion();
            Moto moto = new Moto();
            moto.marca = "Honda";
            moto.modelo = "Honda CB750.";
            moto.anio = 1969;
            moto.TipoManubrio = "Club-bar";
            moto.MostrarInformacion();
            Camioneta camioneta = new Camioneta();
            camioneta.marca = "BMW";
            camioneta.modelo = "BMW X5 SAV";
            camioneta.anio = 1999;
            camioneta.CantidadDePuertas = 4;
            camioneta.Es4x4 = true;
            camioneta.MostrarInformacion();


        }

        public class Vehiculo
        {
            public string marca;
            public string modelo;
            public int anio;

            public void CambiarMarcha()
            {
                Console.WriteLine("Se cambio de marcha");
            }
            public virtual void MostrarInformacion()
            {
                Console.WriteLine($"La marca es: {marca}");
                Console.WriteLine($"El modelo es: {modelo}");
                Console.WriteLine($"El año es de: {anio}");
            }
        }
        public class Auto : Vehiculo
        {
            private int cantidadPuertas;
            private bool esAutomatico;

            public int CantidadPuerta
            {
                get { return cantidadPuertas; }
                set { cantidadPuertas = value; }

            }
            public bool EsAutomatico
            {
                get { return esAutomatico; }
                set { esAutomatico = value; }
            }
            public override void MostrarInformacion()
            {
                Console.WriteLine("A continuacion se va a ver la informacion del auto: ");
                base.MostrarInformacion();
                Console.WriteLine($"La cantidad de puertas que tiene el auto es de: {cantidadPuertas}");
                Console.WriteLine($"El auto automatico: {esAutomatico}");
            }
        }
        public class Moto : Vehiculo
        {
            private string tipoManubrio;

            public string TipoManubrio
            {
                get { return tipoManubrio; }
                set { tipoManubrio = value; }
            }

            public override void MostrarInformacion()
            {
                Console.WriteLine("A continuacion se va a mostrar la informacion de la moto");
                base.MostrarInformacion();
                Console.WriteLine($"El tipo de manubrio que tiene la moto es: {tipoManubrio}");
            }


        }
        public class Camioneta : Vehiculo
        {
            private int cantidadDePuertas;
            private bool es4x4;

            public int CantidadDePuertas
            {
                get { return cantidadDePuertas; }
                set { cantidadDePuertas = value; }
            }
            public bool Es4x4
            {
                get { return es4x4; }
                set { es4x4 = value; }
            }
            public override void MostrarInformacion()
            {
                Console.WriteLine("A continuacion se va a mostrar la infromacion de la camioneta: ");
                base.MostrarInformacion();
                Console.WriteLine($"La cantidad de puertas de la camioneta es de: {cantidadDePuertas}");
                Console.WriteLine($"La camioneta es 4x4: {es4x4}");
            }
        }
    }
}
/*1) Crear la clase Vehiculo que contenga marca, modelo y anio.
Debe tener los métodos:
CambiarMarcha() (simplemente un texto que informe el cambio de marcha)
MostrarInformacion()
Luego, crear tres clases que hereden de Vehiculo
Auto
Camioneta
Moto
Agregar propiedades específicas:
Auto: CantidadPuertas, esAutomatico (booleano)
Moto: TipoManubrio
Camioneta: cantidadPuertas, es4x4 (booleano)
Se deben instanciar en el Main, creando un objeto de cada clase hija y llamar a sus métodos.
*/