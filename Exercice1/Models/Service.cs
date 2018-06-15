using System;
using System.Collections.Generic;
using static System.Console;

namespace Exercice1 
{
    public class Service : Entity
    {
        private List<Entity> _children = new List<Entity>();

        public Service(string name) : base(name) { }

        public override void Add(Entity Entity)
        {
            _children.Add(Entity);
        }

        public override void Remove(Entity Entity)
        {
            _children.Remove(Entity);
        }

        public override void Display(int depth)
        {
            WriteLine(new String('-', depth) + name);

            // Affichage récursif des noeuds
            foreach (Entity entity in _children)
            {
                entity.Display(depth + 2);
            }
        }
    }
}