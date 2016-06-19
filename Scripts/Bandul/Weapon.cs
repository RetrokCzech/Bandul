using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Miko
{
    // Enum of the types of the weapon...
    public enum RareType { Normal, Magic, Rare, Legendary };

    public class Weapon
    {
        
        private int dmg;
        private int durability;
        private string name;

        // Enchant of the weapon
        WeaponEnchant enchant;

        // This is picture of the weapon...
        private Image weapon_image;

        RareType rare;

        /// <summary>
        /// Constructor of the weapon...
        /// </summary>
        /// <param name="dmg">DAMAGE OF THE WEAPON</param>
        /// <param name="durability">DURABILITY OF THE WEAPON</param>
        /// <param name="name">NAME OF THE WEAPON</param>
        /// <param name="image">IMAGE OF THE WEAPON</param>
        /// <param name="rare">RARE TYPE OF THE WEAPON</param>
        /// <param name="enchant">ENCHANT OF THE WEAPON (ANOTHER CLASS)</param>
        public Weapon(int dmg, int durability, string name, Image image, RareType rare, WeaponEnchant enchant)
        {
            this.dmg = dmg;
            this.durability = durability;
            this.name = name;
            this.enchant = enchant;
            weapon_image = image;

            this.rare = rare;

            InitializeImage(rare);


            
        }

        
        // This method initializes image of the weapon (normal, medium, rare or legendary)
        // This method obtains only image for normal or medium type of rareness...
        private void InitializeImage(RareType rare)
        {
            
            // if rare type of the weapon is normal...
            if (rare == RareType.Normal)
            {
                
                // Initializing the bitmap of the weapon
                Bitmap weapon = new Bitmap(weapon_image);

               
                // Making the background of the weapon transparent
                weapon.MakeTransparent(Color.Transparent);

                
                // Saving the modified image of the weapon into Image variable...
                weapon_image = weapon;
            }

            
            // if rare type of the weapon is magic...
            else if (rare == RareType.Magic)
            {
               
                // Initializing the bitmap of the background (resolution of the weapon_image)
                Bitmap background = new Bitmap(weapon_image.Width, weapon_image.Height);

                
                // Initializing Graphics class for cooperating with bitmap (color the bitmap, etc.)...
                Graphics g = Graphics.FromImage(background);

                
                // Initializing for gradient of two colors (Magic = Blue and Black)
                LinearGradientBrush lgb = new LinearGradientBrush(new Rectangle(0, 0, background.Width, background.Height), Color.Blue, Color.Black, LinearGradientMode.Vertical);

                
                // Filling the bitmap rectangle with the LinearGradientBrush...
                g.FillRectangle(lgb, 0, 0, background.Width, background.Height);



                
                //Initializing the image of current weapon...
                Bitmap weapon = new Bitmap(weapon_image);

                
                // Making the background of the weapon transparent
                weapon.MakeTransparent(Color.Transparent);
                
                
                // Insert the weapon into background... 
                // We will get one united bitmap...
                g.DrawImage(weapon, 0, 0, background.Size.Width, background.Size.Height);

             
                //Dispose the graphics... Garbage collector has been rekted... :D
                g.Dispose();


                
                // Saving the modified image of the weapon into Image variable...
                weapon_image = background;
                
            }

            else if (rare == RareType.Rare)
            {
                // Initializing the bitmap of the background (resolution of the weapon_image)
                Bitmap background = new Bitmap(weapon_image.Width, weapon_image.Height);


                // Initializing Graphics class for cooperating with bitmap (color the bitmap, etc.)...
                Graphics g = Graphics.FromImage(background);


                // Initializing for gradient of two colors (Rare = Yellow and Black)
                LinearGradientBrush lgb = new LinearGradientBrush(new Rectangle(0, 0, background.Width, background.Height), Color.Yellow, Color.Black, LinearGradientMode.Vertical);


                // Filling the bitmap rectangle with the LinearGradientBrush...
                g.FillRectangle(lgb, 0, 0, background.Width, background.Height);




                //Initializing the image of current weapon...
                Bitmap weapon = new Bitmap(weapon_image);


                // Making the background of the weapon transparent
                weapon.MakeTransparent(Color.Transparent);


                // Insert the weapon into background... 
                // We will get one united bitmap...
                g.DrawImage(weapon, 0, 0, background.Size.Width, background.Size.Height);


                //Dispose the graphics... Garbage collector has been rekted... :D
                g.Dispose();



                // Saving the modified image of the weapon into Image variable...
                weapon_image = background;

            }

            else if (rare == RareType.Legendary)
            {
                // Initializing the bitmap of the background (resolution of the weapon_image)
                Bitmap background = new Bitmap(weapon_image.Width, weapon_image.Height);


                // Initializing Graphics class for cooperating with bitmap (color the bitmap, etc.)...
                Graphics g = Graphics.FromImage(background);


                // Initializing for gradient of two colors (Legendary = Orange and Black)
                LinearGradientBrush lgb = new LinearGradientBrush(new Rectangle(0, 0, background.Width, background.Height), Color.Orange, Color.Black, LinearGradientMode.Vertical);


                // Filling the bitmap rectangle with the LinearGradientBrush...
                g.FillRectangle(lgb, 0, 0, background.Width, background.Height);




                //Initializing the image of current weapon...
                Bitmap weapon = new Bitmap(weapon_image);


                // Making the background of the weapon transparent
                weapon.MakeTransparent(Color.Transparent);


                // Insert the weapon into background... 
                // We will get one united bitmap...
                g.DrawImage(weapon, 0, 0, background.Size.Width, background.Size.Height);


                //Dispose the graphics... Garbage collector has been rekted... :D
                g.Dispose();



                // Saving the modified image of the weapon into Image variable...
                weapon_image = background;

            }


        }

        /// <summary>
        /// Property of the name of weapon... 
        /// </summary>
        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// Will get the type of the weapon... (Normal, Magic, Rare or Legendary)
        /// </summary>
        public string Type
        {
            get { return rare.ToString(); }
            
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
