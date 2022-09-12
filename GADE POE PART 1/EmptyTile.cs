using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE_PART_1
{
    class EmptyTile : Tile
    {
        public EmptyTile(int x, int y, TileType ConstructType) : base(x, y, ConstructType, '.')
        {

        }
    }
}
