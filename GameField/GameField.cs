//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Server
//{
//    class GameField
//    {
//        Player player;
//        public int[,] Field { get; set; }
//        public GameField()
//        {
//            player = new Player("Miracle");
//            Field = new int[30, 20];
//        }
//        public GameField(uint xSize,  uint ySize)
//        {
//            Field = new int[ySize, xSize];
//        }

//        public void Print()
//        {
//            for (int i = 0; i < Field.GetLength(0); i++)
//            {
//                for (int j = 0; j < Field.GetLength(1); j++)
//                {
//                    Console.SetCursorPosition(j, i);
//                    Console.BackgroundColor = ConsoleColor.DarkGray;
//                    Console.ForegroundColor = ConsoleColor.White;
//                    Console.Write(Field[i, j]);
//                }
//            }
//            Console.ResetColor();
//            Console.WriteLine();
//        }
//        public void ShowAllPlayers()
//        {
            
//        }
//        public void ShowPlayer()
//        {
//            Console.WriteLine(player.Name.ToString());
//        }
//    }
//}
