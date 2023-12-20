using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Factory_Parttern
{
    public class EnemyB : IEnemy
    {
        public State state;

        public EnemyB()
        {
            state = new State();
            state.hp = 15;
            state.maxHp = 15;
            state.mp = 20;
            state.maxMp = 20;
            state.name = "EnemyB";
        }

        public void CreateEnemy()
        {
            CreateEnemy(15, 20, "EnemyB");
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
