using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotgamedotnet.Tests
{
    public class TestSquareRobot : Robot
    {
        public override Action act()
        {
            if (location.x == 10 && location.y == 10)
            {
                // move up
                return new Action { Type = ActionType.Move, MoveLocation = new Point(10, 11) };
            }
            else if (location.x == 10 && location.y == 11)
            {
                // move right
                return new Action { Type = ActionType.Move, MoveLocation = new Point(11, 11) };
            }
            else if (location.x == 11 && location.y == 11)
            {
                // move down
                return new Action { Type = ActionType.Move, MoveLocation = new Point(11, 10) };
            }
            else
            {
                // move left
                return new Action { Type = ActionType.Move, MoveLocation = new Point(10, 10) };
            }
        }
    }

    public class RobotMoveTest
    {
        public static void TestSquareMovement1()
        {
            Board board = new Board(19);
            board._robots.Add(new TestSquareRobot { location = new Point { x = 10, y = 10 } }); // bottom left
            board._robots.Add(new TestSquareRobot { location = new Point { x = 10, y = 11 } }); // top left
            board._robots.Add(new TestSquareRobot { location = new Point { x = 11, y = 11 } }); // top right
            board._robots.Add(new TestSquareRobot { location = new Point { x = 11, y = 10 } }); // bottom right

            board.EvaluateMoves();
        }
    }
}
