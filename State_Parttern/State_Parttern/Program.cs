namespace State_Parttern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character ch = new Character();
            ch.Action();
            ch = new Character(new AttackState());
            ch.Action();
            ch.SetState(new MoveState());
            ch.Action();
        }
    }
}

/*

오브젝트의 상태에 따라 동일한 메서드로 다른 결과물을 제공하는 패턴
캐릭터의 상태를 효과적으로 관리가 가능함

*/