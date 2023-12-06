using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Parttern
{
    // 공격 상태의 클래스
    internal class AttackState : IState
    {
        // IState의 추상 메서드 오버라이드
        public void HandleState(Character character)
        {
            Console.WriteLine("Attack State");
            character.TakingAction();
            // 공격후 대기 상태로 전환
            character.SetState(new IdleState());
            character.Action();
        }
    }
}
