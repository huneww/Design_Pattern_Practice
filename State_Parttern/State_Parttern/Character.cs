using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Parttern
{
    // 캐릭터 클래스
    public class Character
    {
        // 캐릭터의 현재 상태
        private IState curState;

        // 클래스 디폴트 생성자
        public Character()
        {
            curState = new IdleState();
        }

        // IState를 매개변수로하는 생성자
        public Character(IState state)
        {
            curState = state;
        }

        // 캐릭터의 상태 변화
        public void SetState(IState state)
        {
            curState = state;
        }

        // 캐릭터의 행동을 명령하는 메서드
        public void Action()
        {
            curState.HandleState(this);
        }

        public void TakingAction()
        {
            Console.WriteLine("Taking Action!\n");
        }

    }
}
