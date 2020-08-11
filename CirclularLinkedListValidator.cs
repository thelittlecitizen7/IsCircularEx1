using System;
using System.Collections.Generic;
using System.Threading;

namespace LinkedList
{
    public class CirclularLinkedListValidator
    {
        public bool IsCircular<T>(LinkedList<T> linkedList)
        {
            if (linkedList == null)
            {
                return false;
            }
            int countNodes = 0;
            var node = linkedList.First;
            while (node != null && countNodes <= linkedList.Count) 
            {
                node = node.Next;
                countNodes++;
            }
            return (countNodes > linkedList.Count);
        }
    }
}
