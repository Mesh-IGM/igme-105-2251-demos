using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam4Review
{
    internal class MyClass
    {
        public MyClass()
          : this(10)
        {

        }
        public MyClass(int x)
          : this()
        {

        }


        public void DoStuff()
        {
            DoStuff2();
        }

        public void DoStuff2()
        {
            DoStuff();
        }

    }
}
