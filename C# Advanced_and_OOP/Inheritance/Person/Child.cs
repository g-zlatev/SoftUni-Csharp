using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Child : Person
    {
        public Child(string name, int age) : base(name, age)
        {
            
        }

        //public override int Age
        //{
        //    get
        //    {
        //        return base.Age;
        //    }

        //    protected set
        //    {
        //        //if (value < 15)
        //        //{
        //        //    base.Age = value;
        //        //}

        //        if (value > 15)
        //        {
        //            throw new ArgumentException("Child's age cannot be higher than 15!");
        //        }
        //        else
        //        {
        //            base.Age = value;
        //        }
        //    }
        //}

    }
}
