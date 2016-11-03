using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using TodoApi.Models;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoApi.Mvc.Controllers
{
    public class TodoItemController : Controller
    {
        public async Task<ActionResult> Index()
        {

            //Install-Package Newtonsoft.Json
           // Install-Package System.Runtime.Serialization.Xml
              var client = new HttpClient();
            var response = await client.GetAsync("http://localhost:59561/api/todo");
            var todoItem = await response.Content.ReadAsAsync<IEnumerable<TodoItem>>();
            return View(todoItem);
        }
    }
}
