using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ToDoService.Controllers
{
    [Route("api/[controller]")]
    public class ToDoController : Controller
    {
        // GET api/todo
        [HttpGet]
        public IEnumerable<Model.ToDoItem> Get()
        {
            return DataContext.ToDoList.Items;
        }

        // GET api/todo/5
        [HttpGet("{index}")]
        public Model.ToDoItem Get(int index)
        {
            return DataContext.ToDoList.Items.ElementAt(index);
        }

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE api/values/5
        [HttpDelete("{index}")]
        public void Delete(int index)
        {
        }
    }
}
