﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    public abstract class Person
    {
        protected string Name { get; set; }
        protected string LastName { get; set; }
        protected string Document { get; set; }

        public virtual string GetFullName()
        {
            return string.Format("{0} {1}", this.Name, this.LastName);
        }
    }
}
