namespace ECS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entity entity = new Entity(10f);
            entity.PrintAllStat();
            entity.health = 100;
            entity.PrintAllStat();
            entity.transform.RotationTo(120, -31.5f);
            entity.PrintAllStat();
            HealthSystem.Damage(entity, 10f);
            entity.PrintAllStat();
        }
    }
}


/*

게임 오브젝트를 '엔티티', '컴포넌트', '시스템'의 세 가지 요소로 나눕니다.
'엔티티'는 개별 게임 오브젝트를 의미하고,
'컴포넌트'는 그 오브젝트의 특성이나 능력을 정의합니다.
'시스템'은 컴포넌트의 행동을 처리하고 게임 로직을 실행합니다.

*/