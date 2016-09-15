using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Buzz.Models
{
    public class Messages
    {
        public class Message
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public decimal Price { get; set; }
        }
    }
}