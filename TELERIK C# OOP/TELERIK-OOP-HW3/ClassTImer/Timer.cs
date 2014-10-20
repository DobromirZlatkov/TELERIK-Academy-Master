using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ClassTImer
{
    /*Using delegates write a class Timer that has can execute certain method at each t seconds.
    */
    class Timer
    {
    
        public int delay { get; set; }
        public DelegateMethod Propery { get; set; }

        public Timer(int delay, DelegateMethod someMethod)
        {
            this.delay = delay;
            this.Propery = someMethod;
            Thread nt = new Thread(() =>
                {

                    while (true)
                    {
                        this.Propery();
                        Thread.Sleep(this.delay);
                    }

                });
            nt.Start();
        }
        public delegate void DelegateMethod();

    }
}
