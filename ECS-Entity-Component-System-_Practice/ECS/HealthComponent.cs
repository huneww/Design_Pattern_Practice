using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS
{
    // ECS에서 컴포넌트 역할
    // 오브젝트의 체력 상태를 저장
    internal class HealthComponent
    {
        public float health { get; set; }

        private HealthComponent() { }

        public HealthComponent(float health)
        {
            this.health = health;
        }
    }
}
