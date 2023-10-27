using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpookyOS
{
    public class Command
    {
        public string identifier;
        public string description;
        public string usage;

        public virtual void Run(Kernel k,string[] args)
        {

        }
        public virtual void Start(Kernel k, string[] args)
        {
            Run(k, args);
            if(new Random().Next(20) == 0)
            {
                Spooks.MainSpooks.basicSpook();
            }
        }
        public virtual void Run(Kernel k)
        {

        }
    }
}
