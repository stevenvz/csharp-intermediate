using System;
using System.Collections;
using System.ComponentModel;

namespace Exercises_S4_L26
{
    public class Stack
    {
        private ArrayList _stackList = new ArrayList();
        private int _index;

        public void Push(object obj)
        {
            if (obj != null)
            {
                _stackList.Add(obj);
                _index++;
            }
            else
            {
                throw new InvalidOperationException("Cannot pass NULL to the Stack");
            }
            
        }

        public object Pop()
        {
            if (_stackList.Count != 0)
            {
                _index--;
                var returnObject = _stackList[_index];
                _stackList.RemoveAt(_index);
                return returnObject;
            }

            throw new InvalidOperationException("Cannot remove from an empty Stack");
        }

        public void Clear()
        {
            if (_stackList.Count != 0)
            {
                _stackList.Clear();
                _index = 0;
            }
            else
            {
                throw new InvalidOperationException("Cannot remove from an empty Stack");
            }
        }
    }
}