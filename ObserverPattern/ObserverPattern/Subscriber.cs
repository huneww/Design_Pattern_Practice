using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Subscriber : IObserver
    {
        private string name;

        public Subscriber (string name)
        {
            this.name = name;
        }

        // 옵저버 상태 업데이트
        public void Update(string news)
        {
            Console.WriteLine($"{name} received news : {news}");
        }
    }
}
