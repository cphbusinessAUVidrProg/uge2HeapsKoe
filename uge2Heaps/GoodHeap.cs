using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uge2Heaps
{
    public class GoodHeap : IIntHeap
    {
        private int max;
        private int[] elements;
        private int last;
        public GoodHeap()
        {
            max = 20;
            elements = new int[max];
            last = -1;
        }

        public int getTop()
        {
            swap(0, last);
            last--;
            return elements[last + 1];
        }

        public void insert(int element)
        {
            last++;
            if (last == max)
                expand();
            elements[last] = element;
            heapify(last);
        }

        private void expand()
        {
            int newMax = max * 2;
            int[] newElements = new int[newMax];
            Array.Copy(elements, newElements, max - 1);
            elements = newElements;
            max = newMax;
        }

        public bool isEmpty()
        {
            return last < 0;
        }

        public int size()
        {
            return last + 1;
        }

        private void heapify(int i) // heapify node elements[i] in the tree elements[0..last]
        {
            int j = 2 * i + 1;
            if (j <= last)
            {
                if (j + 1 <= last && elements[j] < elements[j + 1])
                    j++;
                if (elements[i] < elements[j])
                {
                    swap(i, j);
                    heapify(j);
                }
            }
        }


        private void swap(int s, int t)
        {
            int tmp = elements[s];
            elements[s] = elements[t];
            elements[t] = tmp;
        }
    }
}
