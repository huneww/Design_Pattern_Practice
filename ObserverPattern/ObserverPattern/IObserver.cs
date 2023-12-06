using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    // 옵저버 베이스 클래스
    public interface IObserver
    {
        abstract void Update(string news);
    }
}
