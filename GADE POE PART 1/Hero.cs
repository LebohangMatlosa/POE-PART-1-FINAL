using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE_PART_1
{
    class Hero :Character
    {
        public Hero(int x, int y, TileType ConstructType, char Symbol, int ConstructHp, int ConstructMaxHP) : base(x, y, ConstructType, 'H')
        {
            damage = 2;
            hp = ConstructHp;
            maxhp = ConstructMaxHP;
        }
        public override MovementEnum ReturnMove(MovementEnum move)
        {
            switch (move)
            {
                case MovementEnum.Up:
                    {
                        x--;
                        return move;
                    }

                case MovementEnum.Down:
                    {
                        x++;
                        return move;
                    }

                case MovementEnum.Left:
                    {
                        y--;
                        return move;
                    }

                case MovementEnum.Right:
                    {
                        y++;
                        return move;
                    }
            }

            return Character.MovementEnum.NoMovement;
        }
        public override String ToString()
        {
            return "Hero" + " at [" + x.ToString() + y.ToString() + "]" + Damage;
        }

    }
}
