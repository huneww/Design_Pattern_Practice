using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    // 기존 인터페이스에서 Build메서드가 추가된 인터페이스
    public interface IProductBuilder_B
    {
        void BuildPartA_B();
        void BuildPartB_B();
        void BuildPartC_B();
        Product GetResult_B();
        void Build();
    }
}
