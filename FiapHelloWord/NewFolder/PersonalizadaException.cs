using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapHelloWord.NewFolder
{
    internal class PersonalizadaException : Exception
    {
        public PersonalizadaException(string? message) : base(message)
        {
        }
    }
}
