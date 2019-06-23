using Coravel.Invocable;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreWorkerServiceSchedularJob
{
    class MyFirstJob  : IInvocable
    {
        public Task Invoke()
        {
            Console.WriteLine("Works fine my first schedule job.......!!!" + DateTime.Now.ToString());
            return Task.CompletedTask;
        }
    }
}
