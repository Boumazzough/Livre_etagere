using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livre_etagere
{
   
        public class MonException : Exception
        {
            private String message;
            public MonException(String message)
            {
                this.message = message;
            }
            public override String Message
            {
                get
                {
                    return message;
                }
            }
        }
}
