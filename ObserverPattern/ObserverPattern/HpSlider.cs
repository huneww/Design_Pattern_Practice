using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class HpSlider : SliderObserver
    {
        // HpSlider생성시 상위 클래스의 생성자로 위임
        public HpSlider() : base() { }

        public HpSlider(float maxValue) : base(maxValue) { }

        // 슬라이더 벨류값 변경
        public override void ChangeSliderValue(float changeValue)
        {
            Value += changeValue;
            if (Value > MaxValue)
                Value = MaxValue;
            Console.WriteLine(Value);
        }
    }
}
