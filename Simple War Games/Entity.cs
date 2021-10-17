using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWarGame
{
    /// <summary>
    /// Abstract Base class for all character agents (AKA Entities).
    /// Every Entity has Health, Armor, and MaxHealth properties.
    /// Every Entity has Attack and Defend methods.
    /// </summary>
    public abstract class Entity : GameObject
    {
        protected int Health;
        protected int Armor;
        protected int MaxHealth;
        public Weapon weapon;//All entities have a weapon

        public int health//definition of Health since its a protected variable, helps us aquire it in other classes
        {
            get//accessor function
            {
                return Health;
            }
            set//mutator function
            {//Health changes depending on value
                if(value > MaxHealth)
                {
                    Health = MaxHealth;
                }
                else if(value <0)
                {
                    Health = 0;
                }
                else
                {
                    Health = value;
                }
            }
        }

        public int armor//definition of Armor since its a protected variable, helps us aquire it in other classes
        {
            get//accessor function
            {
                return Armor;
            }
            set//mutator function
            {
                Armor = value;
            }
        }

        public int maxHealth//definition of MaxHealth since its a protected variable, helps us aquire it in other classes
        {
            get//accessor function
            {
                return MaxHealth;
            }
            set//mutator function
            {
                MaxHealth = value;
            }
        }
        //Attack method is used to take in a entity as a parameter and determines defend function's hit and damage values for the target entity.
        //Hence defend function will be found in attack function and hit value is determined by a random number + attackMod.
        //The damage is determined by the user's weapon max and min values
        public abstract void Attack(Entity target);//abstract class to be used in derived classes
        
        //Defend method takes in hit and damage as parameters. Hit determines if the attack landed. If hit is over the user's armor value, then damage is taken.
        //The damage taken comes from the damage parameter.
        public abstract void Defend(int hit, int damage);//abstract class to be used in derived classes

    }
}
