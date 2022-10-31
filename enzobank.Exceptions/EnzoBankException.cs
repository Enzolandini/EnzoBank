using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enzobank_ATENDIMENTO.enzobank.Exceptions
{

    [Serializable]
    public class EnzoBankException : Exception
    {
        public EnzoBankException() { }
        public EnzoBankException(string message) : base("Aconteceu uma Exceção -> "+ message) { }
        public EnzoBankException(string message, Exception inner) : base(message, inner) { }
        protected EnzoBankException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
