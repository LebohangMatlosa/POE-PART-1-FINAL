using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE_PART_1
{
    class SwampCreature : Enemy
    {
        public SwampCreature(int i, int j, TileType ConstructType, char Symbol, int ConstructEnemyDamage, int ConstructHp) : base(i, j, ConstructType, 'S', 1, 10, 10)
        {

        }
        public override MovementEnum ReturnMove(MovementEnum SwampCreatureMove)
        {
            switch (SwampCreatureMove)
            {
                case MovementEnum.Up:
                    {
                        x--;
                        return SwampCreatureMove;
                    }

                case MovementEnum.Down:
                    {
                        x++;
                        return SwampCreatureMove;
                    }

                case MovementEnum.Left:
                    {
                        y--;
                        return SwampCreatureMove;
                    }

                case MovementEnum.Right:
                    {
                        y++;
                        return SwampCreatureMove;
                    }
            }

            return (MovementEnum)SwampCreatureMove;
        }
        public override String ToString()
        {
            return "SwampCreature" + " at [" + x.ToString() + y.ToString() + "]" + Damage;
        }

    }
}
