using robotgamedotnet.Helpers;
using robotgamedotnet.Robots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotgamedotnet
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player { id = Guid.NewGuid() };
            Player player2 = new Player { id = Guid.NewGuid() };

            Board board = new Board(19);
            board._players.Add(player1);
            board._players.Add(player2);

            for (int i =0; i < Settings.spawn_per_player; i++)
            {
                // player 1 robot
                ExampleRobot er = new ExampleRobot();
                er.player = player1;
                player1.robots.Add(er);
                board.AddRobotToBoard(er);

                WussyRobot wr = new WussyRobot();
                wr.player = player1;
                player2.robots.Add(wr);
                board.AddRobotToBoard(wr);
            }

        }
    }
}
