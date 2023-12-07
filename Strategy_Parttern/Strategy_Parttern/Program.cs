namespace Strategy_Parttern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Sort sort = new Sort();
            // sort의 알고리즘 변경
            sort.Change(new BubleSort());
            // 변경한 알고리즘 실행
            sort.SortMethod(list);
            // sort의 알고리즘 변경
            sort.Change(new SelectionSort());
            // 변경한 알고리즘 실행
            sort.SortMethod(list);
        }
    }
}

/*

특정 알고리즘을 캡슐화하여 실행 시점에서 알고리즘을 선택하여 실행시키는 패턴

*/

// State패턴과의 차이점
/*

State패턴은 오브젝트의 상태에 따라 다음에 실행되는 메서드가 자동으로 실행 됨.
Strategy패턴은 개발자가 그때의 상황에 맞게 변경이 가능하여 유동적으로 알고리즘을 변경할수 있음

*/