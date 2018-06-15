using System;

namespace Exercice2
{
    public class Task
    {
        private Action action;

        public string Name { get; set; }

        // public Task(string name, Action action)
        // {
        //     this.Name = name;
        //     this.action = action;
        // }

        public Task()
        {
            action = () => System.Console.WriteLine("Nothing to do");
        }

        public void Do()
        {
            action.Invoke();
        }

        public static TaskBuilder Builder(){
            return new TaskBuilder();
        }

        #region Builder
        public class TaskBuilder{

            Task task;

            public TaskBuilder()
            {
                task = new Task();
            }

            public TaskBuilder Name (string name){
                task.Name = name;
                return this;
            }

            public TaskBuilder Action (Action action){
                task.action = action;
                return this;
            }

            public Task Build(){
                return task;
            }

        }
        #endregion
        
    }
}