using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWarGame
{
    /// <summary>
    /// Abstract Base Class for all other classes.
    /// Gives every inherited class the Name property.
    /// </summary>
    public abstract class GameObject
    {
        protected string name;
        public string Name//definition of name since its a protected variable, helps us aquire it in other classes
        {
            get//accessor function
            {
                return name;
            }
            set//mutator function
            {
                name = value;
            }
        }
    }
}

