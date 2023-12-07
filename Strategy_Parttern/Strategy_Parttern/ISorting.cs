using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Parttern
{
    // 특정 알고리즘의 베이스 클래스
    public interface ISorting
    {
        void Sort(List<int> list);
    }
}
