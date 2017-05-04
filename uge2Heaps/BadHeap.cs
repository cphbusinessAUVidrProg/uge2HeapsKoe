using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uge2Heaps
{
    public class BadHeap : IIntHeap
    {
        List<int> elements = new List<int>();
        public int getTop()
        {
            int maxIndex = 0;
            for(int i=0; i<elements.Count; i++)
            {
                if (elements[i] > elements[maxIndex])
                {
                    maxIndex = i;
                }
            }
            int ret = elements[maxIndex];
            elements.Remove(ret);
            return ret;
        }

        public void insert(int element)
        {
            elements.Add(element);
        }

        public bool isEmpty()
        {
            return elements.Count == 0;
        }

        public int size()
        {
            return elements.Count;
        }
    }
}
