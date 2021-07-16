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
    
    public class TipoSangre : EnumMisc
    {
        
        private const string S_ON = "O-";
        private const string S_OP = "O+";
        private const string S_AN = "A-";
        private const string S_AP = "A+";
        private const string S_BN = "B-";
        private const string S_BP = "B+";
        private const string S_ABN = "AB-";
        private const string S_ABP = "AB+";
        /*
        public override string GetValue(in int index)
        {
            TipoDeSangreEnum enums = (TipoDeSangreEnum)Enum.Parse(typeof(TipoDeSangreEnum),index.ToString());
            switch (enums)
            {
                case TipoDeSangreEnum.ON:
                    return S_ON;
                case TipoDeSangreEnum.OP:
                    return S_OP;
                case TipoDeSangreEnum.AN:
                    return S_AN;
                case TipoDeSangreEnum.AP:
                    return S_AP;
                case TipoDeSangreEnum.BN:
                    return S_BN;
                case TipoDeSangreEnum.BP:
                    return S_BP;
                case TipoDeSangreEnum.ABN:
                    return S_ABN;
                case TipoDeSangreEnum.ABP:
                    return S_ABP;
                default:
                    return TipoDeSangreEnum.NN.ToString();
            }
        }*/
        // Método temporal para dar funcionalidad nula al método abstracto.
        public override string GetValue(in int index)
        {
            throw new NotImplementedException(M_ERR);
        }
        public override string GetValue(in TipoDeSangreEnum index)
        {
            switch (index)
            {
                case TipoDeSangreEnum.ON:
                    return S_ON;
                case TipoDeSangreEnum.OP:
                    return S_OP;
                case TipoDeSangreEnum.AN:
                    return S_AN;
                case TipoDeSangreEnum.AP:
                    return S_AP;
                case TipoDeSangreEnum.BN:
                    return S_BN;
                case TipoDeSangreEnum.BP:
                    return S_BP;
                case TipoDeSangreEnum.ABN:
                    return S_ABN;
                case TipoDeSangreEnum.ABP:
                    return S_ABP;
                default:
                    return TipoDeSangreEnum.NN.ToString();
            }
        }

        public override List<string> ToList()
        {
            List<string> r = new List<string>(Enum.GetValues(typeof(TipoDeSangreEnum)).Length);
            foreach(TipoDeSangreEnum t in Enum.GetValues(typeof(TipoDeSangreEnum))) r.Add(this.GetValue(t));
            return r;
        }
    }
}