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
        }
    }
}
