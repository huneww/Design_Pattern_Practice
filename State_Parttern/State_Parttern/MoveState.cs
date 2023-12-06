using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Parttern
{
    // 움직이는 상태 클래스
    internal class MoveState : IState
    {
        // IState의 추상 메서드 오버라이드
        public void HandleState(Character character)
        {
            Console.WriteLine("Move State");
            character.TakingAction();
            // 움직이고 대기 상태로 변화
            character.SetState(new IdleState());
            character.Action();
        }
    }
}
