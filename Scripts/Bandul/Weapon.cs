using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Miko
{
    public class Weapon
    {
        private int dmg;
        
        private int durability;
        
        private string name;
        
        WeaponEnchant enchant;
        
        private Image weapon_image;
        
        /// <summary>
        /// Constructor of the weapon...
        /// </summary>
        /// <param name="dmg">DAMAGE OF THE WEAPON</param>
        /// <param name="durability">DURABILITY OF THE WEAPON</param>
        /// <param name="name">NAME OF THE WEAPON</param>
        /// <param name="image">IMAGE OF THE WEAPON</param>
        /// <param name="enchant">ENCHANT OF THE WEAPON (ANOTHER CLASS)</param>
        public Weapon(int dmg, int durability, string name, Image image, WeaponEnchant enchant)
        {
            this.dmg = dmg;
            this.durability = durability;
            this.name = name;
            this.enchant = enchant;
            this.weapon_image = image;            
        }

        /// <summary>
        /// Property of the name of weapon... 
        /// </summary>
        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// Property of the DMG of weapon... 
        /// </summary>
        public int DMG
        {
            get { return dmg; }
        }

        /// <summary>
        /// Property of the durability of weapon... 
        /// </summary>
        public int Durability
        {
            get { return durability; }
        }

        /// <summary>
        /// Property of the Image of weapon... 
        /// </summary>
        public Image Image
        {
            get { return weapon_image; }
        }

        /// <summary>
        /// Property of the Enchant of weapon... 
        /// </summary>
        public WeaponEnchant Enchant
        {
            get { return enchant; }
        }

        /// <summary>
        /// Statement of the weapon informations...
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("This is: {0}; Durability: {1}; DMG: {2} + Enchant DMG: {3};\n Enchant: {4}", name, durability, this.dmg, enchant.AdditionalDMG, enchant.ToString());
        }
    }
}
