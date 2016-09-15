using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static Buzz.Models.Messages;

namespace Buzz.Controllers
{
    public class MessagesController : ApiController
    {
        Message[] messages = new Message[]
       {

            new Message { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Message { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Message { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
       };

        public IEnumerable<Message> GetAllMessages()
        {
            return messages;
        }

        public IHttpActionResult GetMessage(int id)
        {
            var product = messages.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
