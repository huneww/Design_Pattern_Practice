namespace Factory_Parttern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnemyA? enemyA = EnemyFactory.EnemyCreate(EnemyType.TypeA) as EnemyA;
            enemyA.PrintState();
            EnemyB? enemyB = EnemyFactory.EnemyCreate(EnemyType.TypeB) as EnemyB;
            enemyB.PrintState();
        }
    }
}

/*

오브젝트의 생성 관련 기능을 캡슐화
생성 오브젝트의 추가, 제거시에는 Factory 클래스의 분기를 추가, 제거만 하면 된다
클래스 간의 결합도를 낮추는 용도로 주로 사용된다.

*/

// 결합도
/*

A클래스를 변경했을때 A클래스의 변경점이 다른 클래스에서 얼마나 작용하는지
결합도가 낮을수록 A클래스를 변경해도 다른 클래스에 오류가 나타나지 않음

*/