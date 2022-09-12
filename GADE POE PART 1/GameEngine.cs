using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE_PART_1
{
    class GameEngine
    {
        private static readonly char Hero = 'H';
        private static readonly char Empty = '.';
        private static readonly char SwampCreature = 'S';
        private static readonly char Obstacle = 'X';
        private static readonly char Gold = 'G';


        private Map map;

        public GameEngine()
        {
            map = new Map(20, 20, 20, 20, 5);
        }
        public Map GetMap()
        {
            return map;
        }

        public bool MovePlayer(Character.MovementEnum direction)
        {
            return false;
        }
        public override String ToString()
        {
            string text = "";

            for (int x = 0; x < map.borderWidth; x++)
            {
                for (int y = 0; y < map.borderHeight; y++)
                {
                    text += Map.map[x, y].getSymbol();
                }
                text += "\n";
            }

            return text;
        }
        
    }
}
