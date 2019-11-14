using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {
        public Checker[,] Board = new Checker[8, 8];
        public Color CurrentTurn { get; set; }
        public bool GameOn { get; set; }
        public Game()
        {
            GameOn = true;
            for (int i = 0; i< 8; i+=2)
            {
                Board[i, 0] = new Checker(Color.Black, i, 0);
                Board[i + 1, 1] = new Checker(Color.Black, i + 1, 1);
                Board[i, 2] = new Checker(Color.Black, i, 2);

                Board[i + 1, 5] = new Checker(Color.Red, i + 1, 5);
                Board[i, 6] = new Checker(Color.Red, i + 1, 6);
                Board[i + 1, 7] = new Checker(Color.Red, i + 1, 7);
            }
        }
        public string Serialize()
        {
            string state = GameOn.ToString() + "\n";
            state += CurrentTurn.ToString() + "\n";
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if (Board[x,y] != null)
                    {
                        Checker checker = Board[x, y];
                        state += $"{checker.Color}|{checker.King}|{checker.Coords.x}|{checker.Coords.y}";
                    }
                }
            }

            return state;
        }
    }
}
