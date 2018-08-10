using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class ExtensionClase
    {
        public static string MetodoExtension(this string dni)
        {
            string retorna = "";
            for (int i = 0; i < dni.Length; i++)
            {
                if (Char.IsDigit(dni[i]))
                {
                    retorna += dni[i];

                }
                else
                {
                    throw new Exception();
                }

            }
            return retorna;
        }
    }
}
