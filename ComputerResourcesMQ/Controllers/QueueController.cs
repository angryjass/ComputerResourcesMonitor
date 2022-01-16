using ComputerResourcesBase;
using ComputerResourcesMQ.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerResourcesMQ.Controllers
{
    [Controller]
    public class QueueController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody] Packet packet)
        {
            Queue.packets.Enqueue(packet);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var packets = new List<Packet>();
            var sizeInTime = Queue.packets.Count;

            for(var i = 0; i != sizeInTime; i++)
            {
                packets.Add(Queue.packets.Dequeue());
            }

            return Ok(packets);
        }
    }
}
