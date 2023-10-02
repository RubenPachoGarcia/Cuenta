using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta.Servicios
{
    /// <summary>
    /// Interfaz que contiene los procedimientos del menu
    /// 270923 - rpg
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el mensaje de bienvenida
        /// </summary>
        public void mensajeBienvenida();

        /// <summary>
        /// Metodo que muestra el mensaje de bienvenida
        /// </summary>
        public int MenuYOpcionElegida();
    }
}
