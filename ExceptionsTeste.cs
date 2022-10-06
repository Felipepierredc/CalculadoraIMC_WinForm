using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormTentativa1
{
    public class IMCException : Exception
        {
            public IMCException(string mensagem)
                : base(mensagem)
            {
            }
        }
}
