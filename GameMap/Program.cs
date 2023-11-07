using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameMap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new Game_Main();
            game.GameName = "pubg";
            var human = new Human();
            
            var enemy = new Enemy();


            Console.ReadLine();
        }
    }
}
