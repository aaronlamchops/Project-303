using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;
using System.Threading;

namespace Command
{
    public class Invoker
    {
        private Thread _worker;
        private bool _keepGoing;

        private readonly Queue<Command> _todoQueue = new Queue<Command>();
        private readonly AutoResetEvent _enqueueOccurred = new AutoResetEvent(false);

        public void Start()
        {
            _keepGoing = true;
            _worker = new Thread(Run);
            _worker.Start();
        }

        public void Stop()
        {
            _keepGoing = false;
        }

        public void EnqueueCommandForExecution(Command cmd)
        {
            if (cmd != null)
            {
                _todoQueue.Enqueue(cmd);
                _enqueueOccurred.Set();
            }
        }

        private void Run()
        {
            while (_keepGoing)
            {
                if (_todoQueue.Dequeue().Execute())
                {
                    //something when true
                }
                else
                {
                    _enqueueOccurred.WaitOne(100);
                }
            }
        }
    }
}
