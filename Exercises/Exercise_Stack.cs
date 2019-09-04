using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.Exercises
{
    public class Stack
    {
        private readonly List<object> list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("You can not add a null object to the stack.");

            list.Add(obj);
        }

        public object Pop()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("There are no elements in the list.");

            var finalStackValue = list[list.Count() - 1];

            list.RemoveAt((int)finalStackValue - 1);

            return finalStackValue;
        }

        public void Clear()
        {
            list.Clear();
        }
    }
}