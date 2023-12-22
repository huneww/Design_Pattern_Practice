using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    // 구체적인 컴포넌트 클래스
    public class ConcreteComponent : IMyComponent
    {
        public string Operation()
        {
            return "ConcretComponent";
        }
    }
}
