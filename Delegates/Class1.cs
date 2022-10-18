using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class Class1
    {
        public delegate void DoSomethingHandler(bool isOk);
        public DoSomethingHandler DoSomething;

        public int Pow (int x, int y) => x * y;
    }
}
