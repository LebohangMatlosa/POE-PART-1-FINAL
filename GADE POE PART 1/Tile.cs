using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE_PART_1
{
    public abstract class Tile
    {
        protected int x;
        protected int y;
        private char symbol;
        public enum TileType
        {
            Hero = 0,
            Enemy = 1,
            Gold = 2,
            Weapon = 3,
            Obstacle = 4,
            EmptyTile = 5

        }

        public char getSymbol()
        {
            return symbol;
        }

        public int GetY()
        {
            return y;

        }
        public int GetX()
        {
            return x;
        }
        protected TileType TypeEnum;

        public TileType typeEnum
        {
            get { return typeEnum; }
            set { TypeEnum = value; }
        }

        public Tile(int i, int j, TileType ConstructType, char Symbol)
        {
            TypeEnum = ConstructType;
            x = i;
            y = j;
            symbol = Symbol;
        }
    }
}
