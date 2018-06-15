using System;

namespace Exercice1 
{
    public abstract class Entity {
        protected string name;

        // Constructor

        public Entity(string name)
        {
            this.name = name;
        }

        public abstract void Add(Entity c);
        public abstract void Remove(Entity c);
        public abstract void Display(int depth);
    }
}