﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotgamedotnet
{
    public abstract class Robot
    {
        public Guid id { get; private set; }
        public Point location { get; private set; }
        public int hp { get; private set; }
        public Player player { get; private set; }
        public Board board { get; private set; }

        public abstract Action act();
    }
}
