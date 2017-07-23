using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskApp.Models;

namespace TaskApp.Repository
{
  public static class TaskList
    {
        private static  List<Task> tasks = null;
        public static List<Task> GetTasks()
        {
            tasks = new List<Task>()
            {

                new Task()
                {
                    Description="lorepm ipsum task 1",
                    Id=1,
                    Completed=false

                },

                   new Task()
                {
                    Description="lorepm ipsum task 2",
                    Id=2,
                    Completed = false

                },


                      new Task()
                {
                    Description="lorepm ipsum task 3",
                    Id=3,
                    Completed=true

                }



            };
            return tasks;
        }


    }
}