using System;
using static System.Console;

namespace Exercice1 
{
    public class Person : Entity
    {
        public Person(string name) : base(name) { }

        public override void Add(Entity entity)
        {
            WriteLine("On ne peut pas ajouter d'éléments enfants sur cette entité");
        }

        public override void Remove(Entity entity)
        {
            WriteLine("On ne peut pas retirer d'éléments enfants sur cette entité");
        }

        public override void Display(int depth)
        {
            WriteLine(new String('-', depth) + name);
        }
    }
}