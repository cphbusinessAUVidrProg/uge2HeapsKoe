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
            max = 10;
            elements = new int[max];
            last = -1;
        }

        public int getTop()
        {   
            swap(0, last);
            last--;
            if (! isEmpty() )
                heapifyDown(0);
            return elements[last + 1];
        }

        public void insert(int element)
        {
            last++;
            if (last == max)
                expand();
            elements[last] = element;
            heapifyUp(last);
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

        private void heapifyUp(int i) // 
        {
            if (i == 0) return;
            int j = i / 2;
            if (elements[i] > elements[j])
            {
                swap(i, j);
                heapifyUp(j);
            }
        }

        private void heapifyDown(int i) // insert element
        {
            int j = 2 * i + 1;
            if (j <= last)
            {
                if (j + 1 <= last && elements[j] < elements[j + 1])
                    j++;
                if (elements[i] < elements[j])
                {
                    swap(i, j);
                    heapifyDown(j);
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
