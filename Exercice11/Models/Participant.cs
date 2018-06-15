using System;

namespace Exercice11 
{
    public class Participant
    {
        public Participant Next { get; set; }
        public string Name { get; set; }
        public Bomb Bomb { get; set; }

        public Participant Evaluate() {
            if(DateTime.Now.CompareTo(Bomb.Explosion) >= 0){
                System.Console.WriteLine("Explosion");
                return this;
            }
            Next.Bomb = Bomb;
            Bomb = null;
            System.Console.WriteLine($"{Name}");
            return this.Next;
        }
    }
}