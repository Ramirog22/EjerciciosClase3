using Clase3.Ejercicio_1;
using Clase3.Ejercicio_2;

namespace Clase3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 1
            // Crear clase Vehiculo con las siguientes propiedades: Marca, Modelo
            // Crear clase Moto que herede de Vehiculo  
            // Crear clase Auto que herede de Vehiculo

            //Modificar el metodo "ImprimirDatosVehiculo" para que pueda imprimir los datos del Vehiculo independientemente de que si es una moto o un auto 

            //Uso
            Moto m = new Moto() { Marca = "Bajaj", Modelo = "Rouser" };
            Auto a = new Auto() { Marca = "Audi", Modelo = "TT" };
            ImprimirDatosVehiculo(m);
            ImprimirDatosVehiculo(a);
            #endregion


            #region Ejercicio 2
            // Crear una interfaz que se llame IBiblioteca
            // Definir en la interfaz con una sola firma que indique que se va a obtener todos los libros
            // Implementar la interfaz en la clase biblioteca para que devuelva los libros
            // Instanciar y utilizar la clase biblioteca

            Biblioteca b = new Biblioteca();
            b.ObtenerLibros();
            #endregion
        }

        static void ImprimirDatosVehiculo(Vehiculo v) 
        {
            Console.WriteLine("La marca del vehiculo es " + v.Marca + " y su modelo es " + v.Modelo);
        }
    }
}