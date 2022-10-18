using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class Class2
    {
        public int powResult;

        public delegate int DoSomethingElseHandler(int x, int y);
        public void Clac(DoSomethingElseHandler doSomethingElse, int x, int y)
        {
            powResult = doSomethingElse(x, y);
        }

        public bool Result(int a)
        {
            bool isRest = false;

            var rest = powResult % a;
            if (rest==0)
            {
                isRest = true;
            }

            return isRest;
        }
    }
}
