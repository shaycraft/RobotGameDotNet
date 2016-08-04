using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotgamedotnet.Robots
{
    public class ExampleRobot : Robot
    {
        public override Action act()
        {
            // guard if we're in the center
            if (location == rg.CENTER_POINT(board))
            {
                return new Action { Type = ActionType.Guard };
            }

            foreach (var bot in board._robots)
            {
                if (bot.player.id != this.id)
                {
                    if (rg.distance(bot.location, this.location) <=1)
                    {
                        return new Action { Type = ActionType.Attack, p = bot.location };
                    }
                }
            }

            // move towards the center
            return new Action { Type = ActionType.Move, p = rg.toward(this.location, rg.CENTER_POINT(this.board)) };
        }
    }
}
