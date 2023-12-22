using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    // 데코레이트 클래스의 구체적인 클래스
    internal class ConcreteComponent_B : Decorator
    {
        // 매개변수로 넘어온 컴포넌트는 베이스의 컴포넌트 맴버에 저장
        public ConcreteComponent_B(IMyComponent component) : base(component)
        {
        }

        // 메서드 호출시 B클래스의 기능과 베이스클래스의 기능을 호출
        public override string Operation()
        {
            return $"ConcreteComponent_B{base.Operation()}";
        }
    }
}
