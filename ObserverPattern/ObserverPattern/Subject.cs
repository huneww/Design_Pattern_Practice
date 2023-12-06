using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Subject : ISubject
    {
        // 상태를 변경할 옵저버 리스트
        private List<IObserver> observers = new List<IObserver>();
        // 옵저버 리스트에 적용할 값
        private string news = "";

        // 옵저버 리스트 업데이트
        public void NotifyObserver()
        {
            if (news.Equals("")) return;

            foreach (var observer in observers)
            {
                observer.Update(news);
            }
        }

        // 옵저버 리스트에 옵저버 추가
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        // 옵저버 리스트에 옵저버 제거
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        // 변경될 값 저장 후 옵저버 리스트 업데이트
        public void PublishNew(string news)
        {
            this.news = news;
            NotifyObserver();
        }
    }
}
