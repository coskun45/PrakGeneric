using System;
using System.Collections.Generic;
using System.Text;

namespace PrakGeneric
{
    class NoPersonException:Exception
    {
        public NoPersonException()
        {

        }
        public NoPersonException(string s) : base(s)
        {

        }
    }
}
