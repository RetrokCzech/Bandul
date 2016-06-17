using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miko
{
    //
    // Enum of possible enchants...
    //
    public enum EnchantTypes { FIRE, COLD, POISON, SHADOW, HOLY, POSPISIL, SOMOSI, BANDOLA, MIKO, NOTHING }


    public class WeaponEnchant
    {

        private int additional_dmg;

        private int level_of_enchant;

        private EnchantTypes enchant;

        /// <summary>
        /// Constructor of the enchants!
        /// </summary>
        /// <param name="level_of_enchant">Level of the enchant...</param>
        /// <param name="addition_damage">Additional damage that enchant adds to Weapon...</param>
        /// <param name="enchant">Type of the ecnhant... (Fire, Cold, Poison, etc.)</param>
        public Enchant(int level_of_enchant, int addition_damage, EnchantTypes enchant)
        {
            this.level_of_enchant = level_of_enchant;
            this.enchant = enchant;
            

        }


        
        /// <summary>
        /// Name of the enchant
        /// </summary>
        public string Name
        {
            get { return enchant.ToString(); }
        }

        /// <summary>
        /// Damage of the enchant
        /// </summary>
        public int AdditionalDMG
        {
            get { return additional_dmg; }
        }

        /// <summary>
        /// Level of the enchant
        /// </summary>
        public int Level
        {
            get { return level_of_enchant; }
        }

        /// <summary>
        /// Statement about informations of Enchant...
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("Enchant: {0}; Level of Enchant: {1}; Additional DMG: {2}", enchant.ToString(), level_of_enchant, additional_dmg);
        }




    }
}
