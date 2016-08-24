using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotgamedotnet.Helpers
{
    public static class Settings
    {
        public static int spawn_every { get; private set; }
        public static int spawn_per_player { get; private set; }
        public static int robot_hp { get; private set; }
        public static int attack_range { get; private set; }
        public static int collision_damage { get; private set; }
        public static int suicide_damage { get; private set; }
        public static int max_turns { get; private set; }
        public static int guard_damage { get; private set; } // look this up later, stupid fucking robotgame.net is down
        public static int attack_damage { get; set; } // look this up later, stupid fucking robotgame.net is down

        static Settings()
        {
            spawn_every = Int32.Parse(ConfigurationManager.AppSettings["SPAWN_EVERY"]);
            spawn_per_player = Int32.Parse(ConfigurationManager.AppSettings["SPAWN_PER_PLAYER"]);
            robot_hp = Int32.Parse(ConfigurationManager.AppSettings["ROBOT_HP"]);
            attack_range = Int32.Parse(ConfigurationManager.AppSettings["ATTACK_RANGE"]);
            collision_damage = Int32.Parse(ConfigurationManager.AppSettings["COLLISION_DAMAGE"]);
            suicide_damage = Int32.Parse(ConfigurationManager.AppSettings["SUICIDE_DAMAGE"]);
            max_turns = Int32.Parse(ConfigurationManager.AppSettings["MAX_TURNS"]);
            guard_damage = Int32.Parse(ConfigurationManager.AppSettings["GUARD_DAMAGE"]);
            attack_damage = Int32.Parse(ConfigurationManager.AppSettings["ATTACK_DAMAGE"]);
        }
    }
}
