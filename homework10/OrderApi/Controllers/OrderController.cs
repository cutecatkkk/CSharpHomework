using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderService orderService;

        public OrderController(OrderService orderService){
            this.orderService = orderService;
        }
        // GET: api/Order
        [HttpGet]
        public ActionResult<List<Order>> GetTodoItems()
        {
            return orderService.GetAllOrders();
        }

        // GET: api/Order/1
        [HttpGet("{id}")]
        public ActionResult<Order> GetTodoItem(string id)
        {
            var order=orderService.GetOrder(id);
            if (order == null)
            {
                return NotFound();
            }
            return order;
        }

        // POST: api/Order
        [HttpPost]
        public  ActionResult<Order> PostTodoItem(Order order)
        {
            try{
                order.Id=Guid.NewGuid().ToString();
                orderService.Add(order);
            }catch(Exception e){
                return BadRequest(e.InnerException.Message);
            }
           
            return order;
        }   

        // PUT: api/Order/1
        [HttpPut("{id}")]
        public ActionResult<Order> PutTodoItem(string id, Order order)
        {
            if (id != order.Id)
            {
                return BadRequest();
            }
            try{ 
                orderService.Update(order);
            }catch(Exception e){
                string error=e.Message;
                if(e.InnerException!=null) error=e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        // DELETE: api/Order/1
        [HttpDelete("{id}")]
        public ActionResult<Order> DeleteTodoItem(string id)
        {
            try{ 
                orderService.Delete(id);
            }catch(Exception e){
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }



    }


}