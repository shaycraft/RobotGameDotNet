using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotgamedotnet
{
    public class Player
    {
        public Guid id { get; set; }
        public List<Robot> robots { get; set; }
    }
}
