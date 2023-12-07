using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Parttern
{
    internal class Sort
    {
        // 특정 알고리즘의 베이스 클래스 타입의 변수
        private ISorting sorting;

        public Sort()
        {
            sorting = new BubleSort();
        }

        // 알고리즘을 매개변수로 sorting 변수에 저장
        public void Change(ISorting sorting)
        {
            this.sorting = sorting;
        }

        // 현재 sorting의 값에 따라 다른 알고리즘을 실행
        public void SortMethod(List<int> list)
        {
            sorting.Sort(list);
        }

    }
}
