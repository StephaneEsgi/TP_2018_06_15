using System;
using static System.Console;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1TodoTask = TodoTask.Builder()
                .LastName("toto")
                .FirstName("titi")
                .AddTask(Task.Builder()
                             .Name("Faire les courses")
                             .Action(() => WriteLine("-> Je dois faire les courses"))
                             .Build())
                .AddTask(Task.Builder()
                             .Name("Acheter du pain")
                             .Action(() => WriteLine("-> Je dois acheter du pain"))
                             .Build())
                .Build();
            
            WriteLine(person1TodoTask);
            person1TodoTask.DoTasks();
        }
    }
}
