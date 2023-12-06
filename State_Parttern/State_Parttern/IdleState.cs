using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Parttern
{
    // 대기 상태 클래스
    public class IdleState : IState
    {
        // IState의 추상 메서드 오버라이드
        public void HandleState(Character character)
        {
            Console.WriteLine("Idle State");
            character.TakingAction();
        }
    }
}
