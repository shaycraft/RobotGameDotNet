using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotgamedotnet.Robots
{
    public class WussyRobot : Robot
    {
        public override Action act()
        {
            return new Action { Type = ActionType.Guard };
        }
    }
}
