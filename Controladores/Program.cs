using Cuenta.Servicios;

namespace Cuenta
{
    /// <summary>
    /// Clase que controla el procedimiento de la aplicacion
    /// 270923 - rpg
    /// </summary>
    /// </summary>
    class Promgram
    {
        /// <summary>
        /// Metodo que contiene el procedimiento de la aplicacion
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Llamada al metodo
            MenuInterfaz menuInterfaz = new MenuImplementacion();

            menuInterfaz.mensajeBienvenida();

            //Variable que controla el while
            bool cerrarMenu = false;
            //Opcion del usuario
            int opcionSeleccionada;

            //Desde la primera iteracion debe cumplirse la condicion iteracion
            while (!cerrarMenu)
            {
                opcionSeleccionada = menuInterfaz.MenuYOpcionElegida();
                Console.WriteLine(opcionSeleccionada);

                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] - Opcion 0.");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("[INFO] - Opcion 1.");
                        break;

                    case 2:
                        Console.WriteLine("[INFO] - Opcion 2.");
                        break;

                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no esta disponible.");
                        break;
                }
            }
        }
    
    }

}
