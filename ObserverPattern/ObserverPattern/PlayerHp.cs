using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class PlayerHp : ISliderSubject
    {
        // 체력 슬라이더
        // 여러개라면 리스트, 배열로 변경
        private HpSlider? hp;

        public void AddSlider(SliderObserver observer)
        {
            if (observer is HpSlider)
            {
                hp = observer as HpSlider;
                Console.WriteLine("Hp is not Null");
            }
            else
            {
                throw new Exception("Hp is Null");
            }

            //if (observer is HpSlider)
            //{
            //    hp.Add(observer as HpSlider);
            //    Console.WriteLine("Hp is not Null");
            //}
            //else
            //{
            //    throw new Exception("Hp is Null");
            //}
        }

        public void RemoveSlider()
        {
            hp = null;
        }

        //public void RemoveSlider(SliderObserver observer)
        //{
        //    if (observer is HpSlider)
        //    {
        //        hp.Remove(observer as HpSlider);
        //    }
        //}

        public void UpdateSlider(float value)
        {
            // 체력 바가 있는지 확인
            if (hp == null)
            {
                throw new Exception("Hp is Null");
            }

            // hp의 벨류 값 변경
            hp.ChangeSliderValue(value);
        }

        public void Damage(float damage)
        {
            UpdateSlider(-damage);
        }

        public void Heal(float heal)
        {
            UpdateSlider(heal);
        }
    }
}
