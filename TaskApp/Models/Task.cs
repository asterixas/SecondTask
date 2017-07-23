using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskApp.Models
{
    public class Task
    {
       public int  Id { get; set; }
       public string Description { get; set; }

      public bool Completed { get; set; }
    }
}