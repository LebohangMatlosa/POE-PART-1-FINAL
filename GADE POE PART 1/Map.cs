using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE_PART_1
{
    class Map
    {
        public static Tile[,] map;
        public Hero playerCharacter;
        public Enemy[] enemies;
        private int AmtEnemy;
        public int borderHeight;
        public int borderWidth;
        private int mapHeight;
        private int mapWidth;
        private int MinHeight;
        private int MaxHeight;
        private int MinWidth;
        private int MaxWidth;
        private static Random numbers = new Random();
        private static Random rand = new Random();
        private static int enemyAmount = rand.Next(1, 9);
        private static Random SwampCreatureAmount = new Random();
        private static int goblinAmt = SwampCreatureAmount.Next(1, enemyAmount);
      
        
        private static int goldennAmt = SwampCreatureAmount.Next(1, 5);
        public static int goldCollected = 0;
        public static bool canMove = true;
        public static Hero player;
        Enemy enemy;


        public Map(int minHeight, int maxHeight, int minWidth, int maxWidth, int amtEnemy)
        {
            MinHeight = minHeight;
            MaxHeight = maxHeight;
            MinWidth = minWidth;
            MaxWidth = maxWidth;
            AmtEnemy = amtEnemy;

            mapHeight = numbers.Next(minHeight, maxHeight);
            mapWidth = numbers.Next(minWidth, maxWidth);

            borderHeight = mapHeight + 2;
            borderWidth = mapWidth + 2;

            map = new Tile[borderWidth, borderHeight];

            enemies = new Enemy[AmtEnemy];

            MakeMap();
        }
        private Tile Create(Tile.TileType type, Type EnemyType = null)
        {
            int positionX = numbers.Next(1, mapWidth);
            int positionY = numbers.Next(1, mapHeight);

            if (positionX > mapHeight || positionY > mapWidth)
            {
                return Create(type, EnemyType);
            }

            if (type == Tile.TileType.Enemy)
            {
                return (Enemy)Activator.CreateInstance(EnemyType, positionX, positionY, type, EnemyType == typeof(SwampCreature) ? 'G' : 'M', 1, 10);
            }
            else if (type == Tile.TileType.Hero)
            {
                return new Hero(positionX, positionY, type, 'H', 20, 20);
            }


            return new Hero(positionX, positionY, Tile.TileType.Hero, 'H', 20, 20);

        }
        private void MakeMap()
        {
            for (int x = 0; x < borderWidth; x++)
            {
                for (int y = 0; y < borderHeight; y++)
                {
                    map[x, y] = new EmptyTile(x, y, Tile.TileType.EmptyTile);
                    //0000000000
                    if (x == 0 || x == borderWidth - 1 || y == 0 || y == borderHeight - 1)
                    {
                        map[x, y] = new Obstacle(x, y, Tile.TileType.Obstacle);
                    }
                }
            }

            player = (Hero)Create(Tile.TileType.Hero);
            map[player.GetX(), player.GetY()] = player;


            for (int i = 0; i < AmtEnemy; i++)
            {
                enemies[i] = (SwampCreature)Create(Tile.TileType.Enemy, typeof(SwampCreature));
                map[enemies[i].GetX(), enemies[i].GetY()] = enemies[i];
            }

        }
        
        
        public void MoveHero(Character.MovementEnum move)
        {
            int x = player.GetX();
            int y = player.GetY();

            switch (move)
            {
                case Character.MovementEnum.Up:
                    {
                        x--;
                        break;
                    }

                case Character.MovementEnum.Down:
                    {
                        x++;
                        break;
                    }

                case Character.MovementEnum.Left:
                    {
                        y--;
                        break;
                    }

                case Character.MovementEnum.Right:
                    {
                        y++;
                        break;
                    }
            }
            if (map[x, y] is SwampCreature || map[x, y] is Obstacle)
            {
                canMove = false;
                return;
            }

            map[player.GetX(), player.GetY()] = new EmptyTile(player.GetX(), player.GetY(), Tile.TileType.EmptyTile);
            player.ReturnMove(move);
            map[player.GetX(), player.GetY()] = player;

        }
     
    }
}