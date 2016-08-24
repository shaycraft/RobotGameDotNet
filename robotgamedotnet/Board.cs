using robotgamedotnet.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotgamedotnet
{
    public class Board
    {
        public int size { get; set; }

        public bool IsRobotPresent(Point p)
        {
            return _robots.Any(r => r.location.x == p.x && r.location.y == p.y);
        }

        public Board()
        {
            _robots = new List<Robot>();
            _players = new List<Player>();
        }

        private Point[,] _grid;

        public List<Robot> _robots { get; set; }
        public List<Player> _players { get; set; }
        private Dictionary<Robot, Action> _pendingActions = new Dictionary<Robot, Action>();

        // number of turns passed
        private int turn = 0;

        public Board(int size)
        {
            this.size = size;
            _grid = new Point[size, size];
            _robots = new List<Robot>();
            _players = new List<Player>();
        }

        public void AddRobotToBoard(Robot robot)
        {
            Point p = new Point();
            p.x = (new Random()).Next(size);
            p.y = (new Random()).Next(size);
            while (_robots.Where(r => r.location == p).Any())
            {
                p.x = (new Random()).Next(size);
                p.y = (new Random()).Next(size);
            }
            robot.location = p;
            _robots.Add(robot);
            robot.board = this;
        }

        public void DecrementHealth(Robot robot, int health)
        {
            robot.hp -= health;
            if (robot.hp <= 0)
            {
                this._robots.Remove(robot);
            }
        }

        public void EvaluateMoves()
        {
            // query all moves, and see where collisions occur
            foreach (var robot in _robots)
            {
                Action action = robot.act();
                if (action.Type != ActionType.Move)
                {
                    action.MoveLocation = robot.location;
                }
                _pendingActions.Add(robot, action);
            }

            // find all proposed actions

            // now find all collisions based upon location having count > 2
            var collisions = _pendingActions.GroupBy(x => x.Value.MoveLocation, new PointComparer()).Where(x => x.Count() > 1)
                .SelectMany(x => x.ToList()).Select(x => x.Key);

            // now we have all the collisions, so process all the moves
            foreach (var moveAction in _pendingActions.Where(x => x.Value.Type == ActionType.Move))
            {
                Robot robot = moveAction.Key;
                if (collisions.Contains(robot))
                {
                    // collision found
                    // did it guard?
                    if (_pendingActions[robot].Type != ActionType.Guard)
                    {
                        DecrementHealth(robot, Settings.collision_damage);
                    }
                }
                else
                {
                    // no collision, move robot
                    robot.location = _pendingActions[robot].MoveLocation;
                }
            }

            foreach (var attackAction in _pendingActions.Where(x => x.Value.Type == ActionType.Attack))
            {
                Robot robot = attackAction.Key;
                Robot victim = _robots.Where(x => x.location == attackAction.Value.AttackLocation).SingleOrDefault();
                if (victim != null)
                {
                    // did victim guard?
                    if (_pendingActions[victim].Type == ActionType.Guard)
                    {
                        DecrementHealth(victim, Settings.attack_damage / 2);
                    }
                    else
                    {
                        DecrementHealth(victim, Settings.attack_damage);
                    }
                }
            }
        }
    }
}
