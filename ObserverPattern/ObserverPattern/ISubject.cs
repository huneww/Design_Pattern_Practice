using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    // 옵저버를 관리할 베이스 클래스
    public interface ISubject
    {
        abstract void RegisterObserver(IObserver observer);
        abstract void RemoveObserver(IObserver observer);
        abstract void NotifyObserver();
    }
}
