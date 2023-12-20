using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Parttern
{
    public interface IEnemy
    {
        public void CreateEnemy();
        public void CreateEnemy(int hp, int mp, string name);
        public void PrintState();
    }

    public struct State
    {
        public int hp;
        public int maxHp;
        public int mp;
        public int maxMp;
        public string name;
    }
}
