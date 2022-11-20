using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8
{
    internal class CodeExeption:Exception
    {
        public override string Message => "code must be with 3 digits";
    }
}
