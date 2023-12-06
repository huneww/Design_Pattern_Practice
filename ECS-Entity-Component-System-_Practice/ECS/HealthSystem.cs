using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS
{
    // ECS에서 시스템으로
    // 컴포넌트에 명령을 하달
    internal class HealthSystem
    {
        // entity의 체력을 깍는 메서드
        public static void Damage(Entity entity, float damage)
        {   
            if (entity.healthComponent != null)
            {
                entity.healthComponent.health -= damage;
            }
        }
    }
}
