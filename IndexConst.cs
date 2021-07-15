using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FichaMedica
{
    public static class IndexConst
    {
        private const string LBL_ID = "ID";
        private const string LBL_P_NOMBRE = "Primer nombre";
        private const string LBL_S_NOMBRE = "Segundo nombre";
        private const string LBL_P_APELLIDO = "Primer apellido";
        private const string LBL_S_APELLIDO = "Segundo apellido";
        private const string LBL_EDAD = "Edad";
        private const string LBL_TIPO_SANGRE = "Tipo de sangre";
        private const string LBL_BTN_REGISTRAR_FICHA = "Registrar ficha";

        public static string GetValue(in int index){
            switch (index)
            {
                case 0:
                    return LBL_ID;
                case 1:
                    return LBL_P_NOMBRE;
                case 2:
                    return LBL_S_NOMBRE;
                case 3:
                    return LBL_P_APELLIDO;
                case 4:
                    return LBL_S_APELLIDO;
                case 5:
                    return LBL_EDAD;
                case 6:
                    return LBL_TIPO_SANGRE;
                case 7:
                    return LBL_BTN_REGISTRAR_FICHA;
                default:
                    return string.Empty;
            }
        }
    }
}