using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Ejercicios
{
    public class Sale
    {
        public decimal Importe { get; set; }

        public Sale(decimal importe)
        {
            Importe = importe;
        }

        public virtual decimal CalculateTotal()
        {
            return Importe;
        }
    }

    // Minorista
    public class RetailSale : Sale
    {
        public RetailSale(decimal importe) : base(importe) { }

        public override decimal CalculateTotal()
        {
            return Importe;
        }
    }

    // Mayorista
    public class WholesaleSale : Sale
    {
        public WholesaleSale(decimal importe) : base(importe) { }

        public override decimal CalculateTotal()
        {
            return Importe * 0.9m;
        }
    }
}
