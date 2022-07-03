using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Todo.Data;
using Todo.Model;

namespace Todo.Controllers{

    [ApiController]
    public class HomeController : ControllerBase {

        [HttpGet("/")]
        public List<TodoModel> Get([FromServices] AppDbContext context){
            return context.Todos.ToList();
        }
    }
}