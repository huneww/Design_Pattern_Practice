using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS
{
    // ECS에서 시스템 역할
    // 오브젝트의 상태 변경
    internal class Transform
    {
        // 오브젝트의 상태
        public Vector2 position;
        public Vector2 rotation;
        public Vector2 scale;

        public Transform()
        {
            position = Vector2.zero;
            rotation = Vector2.zero;
            scale = Vector2.one;
        }

        public void RotationTo(float x, float y)
        {
            rotation.x = x;
            rotation.y = y;
        }

        public void SetScale(float x, float y)
        {
            scale.x = x;
            scale.y = y;
        }

        public void SetPosition(float x, float y)
        {
            position.x = x;
            position.y = y;
        }

        public void Translate(float x, float y)
        {
            position.x += x;
            position.y += y;
        }
    }
}
