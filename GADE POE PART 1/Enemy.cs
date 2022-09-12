using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE_PART_1
{
    abstract class Enemy : Character
    {
        protected Random r = new Random();

        private int enemyDamage;
        int damageTaken = 2;

        public Enemy(int x, int y, TileType ConstructType, char Symbol, int ConstructEnemyDamage, int ConstructHp, int ConstructMaxHP) : base(x, y, ConstructType, Symbol)
        {
            damage = ConstructEnemyDamage;
            hp = ConstructHp;
            maxhp = ConstructMaxHP;

        }

        public override String ToString()
        {
            return "EnemyClassName" + " at [" + x.ToString() + y.ToString() + "]" + Damage;
        }
        public void TakeDamage()
        {
            Hp -= damageTaken;
        }
        public int EnemyDamage
        {
            get { return enemyDamage; }
            set { enemyDamage = value; }
        }
    }
}
