using ComputerResourcesBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerResourcesMQ.Models
{
    public static class Queue
    {
        public static Queue<Packet> packets = new Queue<Packet>();
    }
}
