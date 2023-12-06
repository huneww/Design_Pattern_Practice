using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public abstract class SliderObserver
    {
        // 슬라이더의 벨류와 최대 벨류
        private float value;
        public float Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }
        private float maxValue;
        public float MaxValue
        {
            get
            {
                return maxValue;
            }
            set
            {
                this.maxValue = value;
            }
        }

        public SliderObserver() : this(100) { }

        public SliderObserver(float maxValue)
        {
            this.maxValue = maxValue;
            this.value = maxValue;
        }

        public abstract void ChangeSliderValue(float changeValue);
    }
}
