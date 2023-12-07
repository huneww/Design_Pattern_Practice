using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Parttern
{
    internal class Test : SingleTon<Test>
    {
        public int testInt;
        private float testFloat;

        public void TestMethod1(int value)
        {
            testInt = value;
        }
        private void TestMEthod2(float value)
        {
            testFloat = value;
        }
    }
}
