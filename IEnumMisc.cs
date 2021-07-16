using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaMedica
{
    public interface IEnumMisc
    {
        string GetValue(in int index);
        string GetValue(in TipoDeSangreEnum index);
        List<string> ToList();
    }
    public abstract class EnumMisc : IEnumMisc
    {
        protected const string M_ERR = "[-] Fuera de contexto enum.";
        public abstract string GetValue(in int index);

        public abstract string GetValue(in TipoDeSangreEnum index);

        public abstract List<string> ToList();
    }
}
