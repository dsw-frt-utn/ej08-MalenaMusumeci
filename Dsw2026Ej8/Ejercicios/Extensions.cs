using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Ejercicios
{
    public static class Extensions
    {
        public static string ToProductCode(this string code)
        {
            if (string.IsNullOrWhiteSpace(code))
                return "SIN CODIGO";

            return code.Trim().ToUpper().Replace(" ", "-");
        }
    }
}
