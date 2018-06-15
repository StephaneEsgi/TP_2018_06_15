using System;
using System.Collections.Generic;

namespace Exercice2 
{
    public class TodoTask 
    {
        private List<Task> tasks = new List<Task>();

        public string LastName { get; set; }
        public string FirstName { get; set; }

        public void DoTasks()
        {
            foreach(var item in tasks)
                item.Do();
        }

        public override string ToString() {
            return $"{FirstName} {LastName}";
        }

        public static TodoTaskBuilder Builder(){
            return new TodoTaskBuilder();
        }

        #region Builder
        public class TodoTaskBuilder
        {
            TodoTask todoTask;

            public TodoTaskBuilder()
            {
                todoTask = new TodoTask();
            }

            public TodoTaskBuilder LastName (string name){
                todoTask.LastName = name;
                return this;
            }

            public TodoTaskBuilder FirstName (string name){
                todoTask.FirstName = name;
                return this;
            }

            public TodoTaskBuilder AddTask (Task task){
                todoTask.tasks.Add(task);
                return this;
            }

            public TodoTask Build(){
                return todoTask;
            }

        }
        #endregion
    }
}