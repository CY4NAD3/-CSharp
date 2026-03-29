using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_ListOfObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            Player player1 = new Player("Chad");
            Player player2 = new Player("Steve");
            Player player3 = new Player("Karen");

            //players.Add(player1);
            //players.Add(player2);
            //players.Add(player3);

            //Or           

            players.Add(new Player("Chad"));
            players.Add(new Player("Steve"));
            players.Add(new Player("Karen"));

            foreach (Player p in players) 
            {
                Console.WriteLine(p);            
            }
            Console.ReadKey();
        }
    }
    class Player
    {
        public String username;

        public Player(String username)
        {
            this.username = username;
        }
        public override string ToString()
        {
            return username;
        }
    }
}
