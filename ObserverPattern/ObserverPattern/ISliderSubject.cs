using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface ISliderSubject
    {
        public void AddSlider(SliderObserver observer);
        public void RemoveSlider();
        public void UpdateSlider(float value);
    }
}
