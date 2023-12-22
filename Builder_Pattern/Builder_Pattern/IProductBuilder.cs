using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    // 빌더 클래스가 상속받을 인터페이스
    public interface IProductBuilder
    {
        void BuildPartA();
        void BuildPartB();
        void BuildPartC();
        Product GetResult();
    }
}
