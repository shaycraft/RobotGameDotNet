using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotgamedotnet
{
    public enum ActionType { Move = 1, Attack = 2, Suicide = 3, Guard = 4 };

    public class Action
    {
        public ActionType Type { get; set; }
        // only used for move
        public Point AttackLocation { get; set; }
        public Point MoveLocation { get; set; }
    }
}
