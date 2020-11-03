namespace CustomStack
{
    using System;
    using System.Collections.Generic;

    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return base.Count.Equals(0);
        }

        public void AddRange(Stack<string> stackAdd)
        {
            while (stackAdd.Count > 0)
            {
                base.Push(stackAdd.Pop());
            }
        }
    }
}
