using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    public class Facade
    {
        // 특정 과정들을 저장할 변수
        protected Sequence_A Sequence_A;
        protected Sequence_B Sequence_B;
        protected Sequence_C Sequence_C;
        
        // 퍼사드 패턴선언시 과정들을 맴버 변수에 저장
        public Facade(Sequence_A sequence_A, Sequence_B sequence_B, Sequence_C sequence_C)
        {
            Sequence_A = sequence_A;
            Sequence_B = sequence_B;
            Sequence_C = sequence_C;
        }

        // 저장한 과정들을 실행후 결과값을 반환
        public string Activation()
        {
            string result = "Facade initializes subSystem\n";
            result += Sequence_A.Sequence();
            result += Sequence_B.Sequence();
            result += Sequence_C.Sequence();

            return result;
        }

    }
}
