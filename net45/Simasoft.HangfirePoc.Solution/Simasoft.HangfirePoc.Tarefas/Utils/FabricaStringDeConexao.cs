using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simasoft.HangfirePoc.Tarefas.Enums;

namespace Simasoft.HangfirePoc.Tarefas.Utils
{
    public class FabricaStringDeConexao
    {
        private static readonly string caa   = string.Empty;
        private static readonly string canf  = string.Empty;
        private static readonly string capy  = string.Empty;
        private static readonly string cai   = string.Empty;
        private static readonly string cav   = string.Empty;
        private static readonly string caan  = string.Empty;
        private static readonly string caja  = string.Empty;
        private static readonly string caj   = string.Empty;
        private static readonly string capam = string.Empty;
        private static readonly string cap   = string.Empty;
        private static readonly string can   = string.Empty;

        private FabricaStringDeConexao()
        {
            
        }

        public static string Fabrica(EConcessionaria codigoConcessionaria)
        {
            switch (codigoConcessionaria)
            {
                case EConcessionaria.CAA:
                    return caa;     
                case EConcessionaria.CANF:
                    return canf;
                case EConcessionaria.CAPY:
                    return capy;
                case EConcessionaria.CAI:
                    return cai;
                case EConcessionaria.CAV:
                    return cav;
                case EConcessionaria.CAAN:
                    return caan;                
                case EConcessionaria.CAJA:
                    return caja;
                case EConcessionaria.CAJ:
                    return caj;
                case EConcessionaria.CAPAM:
                    return capam;
                case EConcessionaria.CAP:
                    return cap;
                case EConcessionaria.CAN:
                    return can;
            }
            return null;
        }
    }
}
