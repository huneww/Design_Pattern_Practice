using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class Decorator : IMyComponent
    {
        // 컴포넌트 저장 변수
        protected IMyComponent component;

        public Decorator(IMyComponent component)
        {
            this.component = component;
        }

        // 컴포넌트의 메서드를 실행
        public virtual string Operation()
        {
            return component.Operation();
        }
    }
}
