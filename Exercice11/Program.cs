using System;
using System.Threading.Tasks;

namespace Exercice11
{
    class Program
    {
        static void Main(string[] args)
        {
            var node1 = Init(10,20);
            RunProgram(node1);
            Console.ReadKey();
        }

        static void RunProgram(Participant node1){
            Task.Run(async () =>
            {
                var current = node1;
                var shouldContinue = true;
                while (shouldContinue)
                {
                    var result = current.Evaluate();
                    shouldContinue = !result.Equals(current);
                    current = result;
                    await Task.Delay(1000);
                }
            });
        }

        static Participant Init(int lower, int higher){
            Participant node1 = new Participant { Name = "Participant 1" };
            Participant currentParticipant = node1;
            for (int i = 2; i <= 10; i++)
            {
                var next = new Participant { Name = "Participant " + i };
                currentParticipant.Next = next;
                currentParticipant = next;
            }

            Random r = new Random();
            node1.Bomb = new Bomb{ Explosion = DateTime.Now.AddSeconds(r.Next(lower, higher)) };
            currentParticipant.Next = node1;
            return node1;
        }
    }
}
