using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Cls_Uteis
    {
        public static string ConsultaCNPJ(String cnpj) 
        {
            if (cnpj == "01.901.050/0001-02")
            {
                return "RIOSFARMA COMERCIO DE MEDICAMENTOS LTDA";
            } 
            else 
            {
                return "CNPJ não encontrado em nossa base de dados!";
            }
        }
    }
}
