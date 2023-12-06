using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ECS
{
    // ECS에서 컴포넌트 역할
    // 오브젝트의 상태를 저장
    internal class Vector2
    {
        public float x { get; set; }
        public float y { get; set; }

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector2 zero
        {
            get { return new Vector2(0, 0); }
        }

        public static Vector2 one
        {
            get { return new Vector2(1, 1); }
        }

        public static Vector2 up
        {
            get { return new Vector2(0, 1); }
        }

        public static Vector2 down
        {
            get { return new Vector2(0, -1); }
        }

        public static Vector2 right
        {
            get { return new Vector2(1, 0); }
        }

        public static Vector2 left
        {
            get { return new Vector2(-1, 0); }
        }

        public void Set(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        // 출력시 특정 방식으로 출력
        public override string ToString()
        {
            return "{ " + x + ", " + y + " }";
        }

    }
}
