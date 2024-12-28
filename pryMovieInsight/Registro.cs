using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pryMovieInsight
{
    internal class Registro
    {
        public struct RegGen 
        {
            public  Int32 Código;
            public  String Nombre;
            public  String Descripción;            
        }

        public static RegGen[] Genero = new RegGen[10]; //Vector constituido por registro
        public static Int32 IND;

        public static String[] Meses = new String[12] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};

    }
}
