using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miko
{
    /// <summary>
    /// Abstract class for every monsters in the game!
    /// </summary>
    public abstract class Monster : Enemy
    {

        /// <summary>
        /// Another constructor for Monster...
        /// </summary>
        public Monster(string name, int health, int defense, int level) : base(name, health, defense, level)
        {

        }

        public override string ToString()
        {
            return base.ToString() + "Monster" + "\n"; 
        }
    }
}
