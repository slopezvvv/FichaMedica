using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FichaMedica
{
    public enum TipoDeSangreEnum
    {
        NN,ON,OP,AN,AP,BN,BP,ABN,ABP
    }
    public static class TipoSangre
    {
        private static TipoDeSangreEnum _tipo = TipoDeSangreEnum.NN;

        public static string GetValue(in int index)
        {

        }
    }
}