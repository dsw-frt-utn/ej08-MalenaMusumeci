using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Ejercicios
{
    public class Product
    {
        private string descripcion;

        public Product(string descripcionInicial)
        {
            this.descripcion = descripcionInicial;
        }

        public void CambiarDescripcion(string nuevaDescripcion)
        {
            this.descripcion = nuevaDescripcion;
        }

        public string GetDescripcion()
        {
            return this.descripcion;
        }
    }
}
