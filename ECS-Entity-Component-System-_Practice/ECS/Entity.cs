using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS
{
    // 오브젝트
    internal class Entity
    {
        public Transform transform;
        public HealthComponent healthComponent;
        public float health
        {
            get
            {
                return healthComponent.health;
            }
            set
            {
                healthComponent.health = value;
            }
        }

        public Entity() : this(0) { }

        public Entity(float health)
        {
            transform = new Transform();
            healthComponent = new HealthComponent(0);
            this.health = health;
        }

        public void PrintAllStat()
        {
            Console.WriteLine("Transform.position : " + transform.position);
            Console.WriteLine("Transform.rotation : " + transform.rotation);
            Console.WriteLine("Transform.Scale : " + transform.scale);
            Console.WriteLine("Entity Health : " + healthComponent.health);
            Console.WriteLine();
        }
    }
}
