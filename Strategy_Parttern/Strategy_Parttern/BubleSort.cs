using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Parttern
{
    // 베이스 클래스를 상속받는 알고리즘
    internal class BubleSort : ISorting
    {
        public void Sort(List<int> list)
        {
            Console.WriteLine("BubleSort");
        }
    }
}
