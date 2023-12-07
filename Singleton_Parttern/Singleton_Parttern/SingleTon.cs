using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Parttern
{
    // T타입의 제네릭 싱글톤
    // T타입은 참조타입이면서 매개변수가 없는 생성자가 있는 타입이여야 한다
    internal class SingleTon<T> where T : class, new()
    {
        // T타입의 인스턴스
        private static T instance;
        // 인스턴스의 중복 생성을 맞기 위한 lock변수
        private static readonly object _lock = new object();
        // T타입의 인스턴스 프로퍼티
        public static T Instance
        {
            get
            {
                lock(_lock)
                {
                    if (instance == null)
                    {
                        instance = new T();
                    }

                    return instance;
                }
            }
        }
    }
}

/*

프로그램 내에서 두개 이상의 동일한 맴버가 있는 것을 막는 패턴

*/
