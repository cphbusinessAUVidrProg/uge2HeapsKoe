using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uge2Heaps
{
    public class GoodHeap : IIntHeap
    {
        // inv:
        // max er antal elementer i elements array
        // elementer[0..last] er org. som max-heap
        // last == -1 means empty
        private int max;
        private int[] elements;
        private int last;

        // pre: none
        // post: objektet er "velinitialiseret" (klasse invarianten er etableret)
        public GoodHeap(int startSize=20)
        {
            max = startSize;
            elements = new int[max];
            last = -1;
        }

        
        // pre: heap is not empty
        // post: top element is returned & removed
        public int getTop()
        {
            swap(0, last);
            last--;
            if (! isEmpty() )
                heapifyDown(0);
            return elements[last+1];
        }

        // pre: et vilkårligt heltal
        // post: element er i heap
        public void insert(int element)
        {
            last++;
            if (last == max)
                expand();
            elements[last] = element;
            heapifyUp(last);
        }

        // pre: ingen pre-betingelse
        // post: returns true if empty 
        public bool isEmpty()
        {
            return last < 0;
        }

        // pre: ingen pre-betingelse
        // post: returnerer antal elementer
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
        private void expand()
        {
            int newMax = max * 2;
            int[] newElements = new int[newMax];
            Array.Copy(elements, newElements, max-1);
            elements = newElements;
            max = newMax;
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

        // pre: ingen prebetingelse
        // post: returnerer og fjerner toppen hvis ikke tom
        // ellers v
        public int getTopOr(int v)
        {
            if (isEmpty())
                return v;
            else
                return getTop(); 
        }
    }
}
