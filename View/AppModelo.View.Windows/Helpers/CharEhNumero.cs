using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.View.Windows.Helpers
{
    internal static partial class Componentes
    {
        internal static bool CharEhNumero(string texto)
        {
            foreach(var letra in texto)
            {
                if (char.IsNumber(letra))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
