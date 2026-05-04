using Dsw2026Ej8.Ejercicio1;
using Dsw2026Ej8.Ejercicios;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EJERCICIO 1
            ProductHelper helper = new ProductHelper();
            string etiqueta = helper.ObtenerEtiquetaProducto(12345, "Monitor", 10000.55m);
            
            Console.WriteLine(etiqueta);


            // EJERCICIO 2
            Problema2 p2 = new Problema2();
            string resumen = p2.CrearResumenVenta(101, "Teclado", 2, 1500.32m);
            
            Console.WriteLine(resumen);

            // EJERCICIO 3
            Product Producto = new Product("Original");
            int num = 10;

            Problema3 p3 = new Problema3();
            string resultado = p3.CompararCopias(num, Producto);

            Console.WriteLine(resultado);

            // EJERCICIO 4
            Problema4 p4 = new Problema4();
            double prom = p4.CalcularPromedio(10, null, 8);
            
            Console.WriteLine($"Promedio: {prom}");

            // EJERCICIO 5
            Problema5 p5 = new Problema5();
            Sale ventaMayorista = new WholesaleSale(1000);
            decimal final = p5.ObtenerImporteFinal(ventaMayorista);
            
            Console.WriteLine($"Importe Final (Mayorista): {final:C}");

            // EJERCICIO 6
            Problema6 p6 = new Problema6();
            string codigoLimpio = p6.NormalizarCodigoProducto("ab 123 x");
            
            Console.WriteLine($"Código: {codigoLimpio}");
        }
    }
}
