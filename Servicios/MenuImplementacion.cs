using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta.Servicios
{
    /// <summary>
    /// Implementacion de las acciones del menu
    /// 270923 - rpg
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mensajeBienvenida()
        {
            string mensaje1 = "Bienvenido/a, aqui podras crearte una nueva cuenta de CSI1";

            Console.WriteLine(mensaje1);
        }
        public int MenuYOpcionElegida()
        {
            int opcionElegida;
            Console.WriteLine("-------------------------");
            Console.WriteLine("0. Crear nueva cuenta");
            Console.WriteLine("-------------------------");
            Console.WriteLine("¿Ya tienes cuenta?");
            Console.WriteLine("1. Iniciar sesion");
            Console.WriteLine("-------------------------");
            Console.WriteLine("2. Cerrar y salir");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Seleccione una opcion: ");

            opcionElegida = Console.ReadKey(true).KeyChar - ('0');

            return opcionElegida;
        }

        
    }
}
