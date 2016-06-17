using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
// Part of my library... :]
//
namespace Miko
{
    /// <summary>
    /// abstract class for every enemy, hero, companion etc.
    /// </summary>
    public abstract class Enemy
    {
        protected string name;
        protected int health;
        protected int max_health;
        protected int level;
        

        /// <summary>
        /// This is constructor. This constructor can be modified in each other class that inherits...
        /// </summary>
        /// <param name="name">Name of the enemy!</param>
        /// <param name="health">Health of the enemy!</param>
        /// <param name="level">Level of the enemy!</param>
        public Enemy(string name, int health, int level)
        {
            this.name = name;
            this.health = health;
            max_health = health;
            
            this.level = level;
        }

        /// <summary>
        /// This method
        /// </summary>
        /// <param name="enemy"></param>
        public virtual void Attack(Enemy enemy)
        {

        }

        /// <summary>
        /// Defend of enemy... If he has some armor or something like that...
        /// </summary>
        public virtual void Defend()
        {

        }

        /// <summary>
        /// Bool return method... If health of the enemy is greater than 0, the enemy is alive...
        /// </summary>
        /// <returns></returns>
        public bool Alive()
        {
            return health > 0;
        }

        /// <summary>
        /// Statement of information about enemy...
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("This is: {0}; Health: {1} / {2};", name, health, max_health);
        }

        /// <summary>
        /// Property of health...
        /// </summary>
        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        /// <summary>
        /// Property of max health...
        /// </summary>
        public int MaxHealth
        {
            get { return max_health; }
        }
    }
}
