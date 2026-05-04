using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Ejercicio1
{
    public partial class ProductHelper
    {
        public string ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
            return SimboloApertura + code.ToString() + "] " + description + " - " + price.ToString("C");
        }
    }
}
