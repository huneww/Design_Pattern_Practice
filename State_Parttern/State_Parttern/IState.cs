using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Parttern
{
    // 상태의 상위 클래스
    public interface IState
    {
        // Character 타입의 변수를 매개변수로 받아
        // 특정행동을 취하고 후속 행동을 이어서 하기 위해서
        abstract void HandleState(Character character);
    }

}
