using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Miko
{
    /// <summary>
    /// Inheriting Warrior to Bandul class
    /// </summary>
    public class Bandul : IWarrior, IMage, IRogue
    {
        private string name;

        private int health, max_health;

        private int level;

        private Weapon weapon;

        //
        // This is static image for Bandul... :]
        //
        private static Image bandul_picture = Properties.Resources._13170749_489222574605427_1814172887_o;

        public Bandul(string name, int health, int level, Weapon weapon)
        {
            this.name = name;
            this.health = health;
            this.max_health = health;
            this.level = level;
            this.weapon = weapon;

        }

        public int GivenDMG
        {
            get
            {
                //TODO get a dmg I give to enemy..
                return 0;
            }
        }

        public int Mana
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Level
        {
            get { return level; }
        }

        public int Defense
        {
            get { return defense; }
        }

        public Weapon Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }

        public static Image BandulAvatar
        {
            get { return bandul_picture; }
        }

        
               
        public void Attack(Enemy war)
        {
            //TODO attack warrior
        }

        public void Avoid()
        {
            //TODO avoid an attack of enemy...
        }

        public void GetInfo()
        {
            //just developing things
        }

        public void Defend()
        {
            //TODO defend taken dmg
        }

        public void FireBall(Enemy war)
        {
            //
            //Attack enemy with fireball - base dmg + fire dmg for 5 secs...
            //
        }
                
        public void SummonCompanion()
        {
            //
            //TODO summon skeleton
            //
        }

        /// <summary>
        /// This method will write information about player...
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("This is: {0}; Health: {1} / {2};", name, health, max_health) + "\n" + weapon.ToString();
        }

        public void Freeze(Enemy war)
        {
            //
            //TODO mage freeze enemy
            //
        }
    }
}
