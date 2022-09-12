using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE_PART_1
{
    abstract class Character :  Tile
    {
        bool dead = false;
        protected int Hp;
        protected char Symbol;
        protected int MaxHp;
        protected int Damage;

        public Tile[] characterVision = new Tile[4];

        public int hp
        {
            get { return Hp; }
            set { Hp = value;}
        }

        public int maxhp
        {
            get { return MaxHp;  }
            set { MaxHp = value;  }

        }
        public int damage
        {
            get { return Damage; }
            set { Damage = value; }
        }

        public enum MovementEnum
        {
            NoMovement = 0,
            Up = 1,
            Left = 2,
            Right = 3,
            Down  = 4,
        }

        public enum AttackEnum
        {
            NoAttack = 0,
            Up = 1,
            Left = 2,
            Right = 3,
            Down = 4,
        }
        protected Character(int x, int y, TileType ConstructType, char ConstructSymbol) : base(x, y, ConstructType, ConstructSymbol)
        {
            ConstructSymbol = Symbol;
        }

        public int Positions()
        {
            return x;
        }
        
        public virtual void Attaack(Character target)
        {
            target.Hp = target.hp - 10;
        }

        public bool IsDead()
        {
            if(Hp < 1)
            {
                dead = true; 
            }
            return dead;
        }

        public virtual bool CheckRange(Character target)
        {
            return true;
        }
        
        private int DistanceTo(Character target)
        {
            return 5;
        }

        public void Move(MovementEnum move)  //Edites a units X and Y valaues in order to move it
        {

        }

        public abstract MovementEnum ReturnMove(MovementEnum move = 0);

        public abstract override string ToString();






    }
}
