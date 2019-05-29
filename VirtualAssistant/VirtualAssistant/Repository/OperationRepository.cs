using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAssistant.Repository
{
    public static class OperationRepository
    {

        public static string[] Operadores
        {
            get
            {
                return new string[]
                {
                    "mais",
                    "menos",
                    "dividido",
                    "vezes"
                };
            }
        }
    }
}
