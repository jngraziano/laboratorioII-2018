using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class Extension
    {
        public static string FormatoTabla(this String espacios,int num)
        {
          
            try
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < espacios.Length; i++)
                {
                    sb.AppendLine(string.Format("0,{1}",num));
                    
                }

                return sb.ToString() ;
            }
            catch (Exception excep)
            {

                throw excep;

            }

         

        }
    }
}
