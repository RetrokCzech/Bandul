using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miko
{
    /// <summary>
    /// This is class for every animal in this game...
    /// </summary>
    public  abstract class Animal : Enemy
    {
        
        int dmg;
        /// <summary>
        /// This is constructor of Animal class
        /// </summary>
        public Animal(string name, int health, int defense, int level, int dmg) : base(name, health, defense, level)
        {
            this.dmg = dmg;
        }

        public override void Attack(Enemy enemy)
        {
            
        }

        public override string ToString()
        {
            return base.ToString() + "Animal" + "\n";
        }
    }
}
