using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Todo.Data;
using Todo.Model;

namespace Todo.Controllers{

    [ApiController]
    public class HomeController : ControllerBase {

        [HttpGet("/")]
        public IActionResult Get([FromServices] AppDbContext context) => Ok(context.Todos.ToList());

        [HttpGet("/{id:int}")]
        public IActionResult GetById([FromRoute] int id, [FromServices] AppDbContext context){
            
            var todo = context.Todos.Find(id);
            if(todo == null)
                return NotFound();

            return Ok(todo);           
        }

        [HttpPost("/")]
        public IActionResult Post([FromBody] TodoModel todo, [FromServices] AppDbContext context){
            
            context.Todos.Add(todo);
            context.SaveChanges();
            return Created($"/{todo.Id}", todo);
        }

        [HttpPut("/{id:int}")]
        public IActionResult Put([FromRoute] int id, [FromBody] TodoModel todo, [FromServices] AppDbContext context){
            
            var todoModel = context.Todos.Find(id);
            
            if(todoModel == null)
                return NotFound();
            
            todoModel.Title = todo.Title;
            todoModel.Done = todo.Done;

            context.Todos.Update(todoModel);
            context.SaveChanges();
            
            return Ok(todoModel);
        }

        [HttpDelete("/{id:int}")]
        public IActionResult Delete([FromRoute] int id, [FromServices] AppDbContext context){
            
            var todoModel = context.Todos.Find(id);
            if(todoModel == null)
                return NotFound();

            context.Todos.Remove(todoModel);
            context.SaveChanges();
            
            return Ok(todoModel);
        }
    }
}