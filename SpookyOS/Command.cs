﻿using System;
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
        public virtual void Run(Kernel k)
        {

        }
    }
}
