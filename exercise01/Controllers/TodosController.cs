using exercise01.Model;
using exercise01.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace exercise01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private TodoSevice _todoSevice;

        public TodosController() 
        {
            _todoSevice = new TodoSevice();
        }
        [HttpGet("{id?}")]  
        public IActionResult GetTodos(int? id) 
        {
            var myTodos = _todoSevice.AllTodos();
            if (id is null) return Ok(myTodos);

            myTodos = myTodos.Where(t=> t.Id == id).ToList();
            return Ok(myTodos);
        }

        
    }
}
