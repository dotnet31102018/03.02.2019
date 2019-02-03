using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0302
{
    class Program
    {
        static void Main(string[] args)
        {
            Game chess = new Game("Chess", 2, 9.5f, "Persia");
            Game soccer = new Game("Soccer")
            {
                _originCountry = "Brazil"
            };
            soccer._numberOfPlayers = 22;

        }

        static void PrintGame(Game game)
        {
            Console.WriteLine(game);
            int number = game.TellMeHowManyPlayers();
        }
    }
}
