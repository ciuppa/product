﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class Topic
    {
        public Topic(string name)
        {
            Name = name;
        }

	public Topic()
        {
            Name = name;
        }

        public void MethodA()
        {
            MethodC(Name);
        }

        public void MethodB()
        {
        }

        public void MethodC(string name)
        {
        }

        public string Name
        {
            get;
            set;
        }
    }
}
