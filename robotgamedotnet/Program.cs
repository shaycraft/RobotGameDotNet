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

            for (int i = 0; i < Settings.spawn_per_player; i++)
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

            for (int i = 0; i < Settings.max_turns; i++)
            {
                board.EvaluateMoves();

                //Dictionary<Guid, Action> actions = new Dictionary<Guid, Action>();
                //foreach (var robot in board._robots)
                //{
                //    actions.Add(robot.id, robot.act());
                //}
                //var guards = actions.Where(x => x.Value.Type == ActionType.Guard).Select(x => x.Key).ToList();
                //foreach (var action in actions)
                //{
                //    var robot = board._robots.Where(x => x.id == action.Key).SingleOrDefault();
                //    switch (action.Value.Type)
                //    {
                //        case ActionType.Move:
                //            if (board._robots.Any(r => r.location == action.Value.ActionLocation))
                //            {
                //                robot.hp -= Settings.collision_damage;
                //            }
                //            else
                //            {
                //                robot.location = action.Value.ActionLocation;
                //            }
                //            break;
                //        case ActionType.Attack:
                //            var victim = board._robots.Where(p => p.location == action.Value.ActionLocation).SingleOrDefault();
                //            if (victim != null)
                //            {
                //                if (guards.Any(x => x == victim.id))
                //                {
                //                    victim.hp -= Settings.guard_damage;
                //                }
                //                else
                //                {
                //                    victim.hp -= Settings.attack_damage;
                //                }
                //            }
                //            break;
                //        case ActionType.Guard:
                //            break;
                //        default:
                //            break;
                //    }
                //}
            }
        }
    }
}
