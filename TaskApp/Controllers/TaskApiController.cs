using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaskApp.Repository;
using TaskApp.Models;

namespace TaskApp.Controllers
{
    public class TaskApiController : ApiController
    {
        // GET: api/TaskApi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2","value3","value4" };
        }

        // GET: api/TaskApi/5
        public string Get(int id)
        {
            return "value";
        }
        /// <summary>
        /// new comments
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>

        public IHttpActionResult Post(HttpRequestMessage request)
        {
          int newId= TaskList.GetTasks().Count()+1;
            var description = request.Content.ReadAsStringAsync().Result;
            Task newTask = new Task { Description = description.Substring(description.IndexOf("=")+1), Id = newId };
           


           
            if (newTask != null)
            {
                return Created<Task>(Request.RequestUri + newTask.Id.ToString(), newTask);
            }
            else
            {
                return Conflict();
            }

        }

        // PUT: api/TaskApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TaskApi/5
        public void Delete(int id)
        {

            TaskList.GetTasks().Remove(TaskList.GetTasks().Where(t => t.Id == id).FirstOrDefault());

           

         
        }
    }
}
