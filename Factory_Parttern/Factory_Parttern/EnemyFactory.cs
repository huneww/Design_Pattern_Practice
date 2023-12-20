using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Parttern
{
    public enum EnemyType
    {
        TypeA,
        TypeB
    }

    public class EnemyFactory
    {
        public static IEnemy EnemyCreate(EnemyType type)
        {
            switch(type)
            {
                case EnemyType.TypeA:
                    EnemyA enemyA = new EnemyA();
                    return enemyA;
                case EnemyType.TypeB:
                    EnemyB enemyB = new EnemyB();
                    return enemyB;
                default:
                    throw new Exception("Enemy Type is wrong");
            }
        }

        public IEnemy EnemyCreate_2(EnemyType type)
        {
            switch (type)
            {
                case EnemyType.TypeA:
                    return new EnemyA();
                case EnemyType.TypeB:
                    EnemyB enemyB = new EnemyB();
                    return enemyB;
                default:
                    throw new Exception("Enemy Type is wrong");
            }
        }
    }
}
