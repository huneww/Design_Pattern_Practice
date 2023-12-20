using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Factory_Parttern
{
    public class EnemyA : IEnemy
    {
        public State state;

        public EnemyA()
        {
            state = new State();
            state.hp = 10;
            state.maxHp = 10;
            state.mp = 10;
            state.maxMp = 10;
            state.name = "EnemyA";
        }

        public void CreateEnemy()
        {
            CreateEnemy(10, 10, "EnemyA");
        }

        public void CreateEnemy(int hp, int mp, string name)
        {
            state = new State();
            state.hp = hp;
            state.maxHp = hp;
            state.mp = mp;
            state.maxMp = mp;
            state.name = name;
        }

        public void PrintState()
        {
            Console.WriteLine($"Name : {state.name}");
            Console.WriteLine($"Hp : {state.hp} / {state.maxHp}");
            Console.WriteLine($"Mp : {state.mp} / {state.maxMp}");
        }
    }
}
