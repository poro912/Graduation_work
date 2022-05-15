﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Server
{
    class Queue
    {
        Queue<Communicator> process;
        Queue<Communicator> send;
        Queue<Communicator> receive;
        Queue<Thread> subscribers;
    }
}
