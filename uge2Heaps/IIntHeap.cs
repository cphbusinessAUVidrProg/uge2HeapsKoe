using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uge2Heaps
{
    public interface IIntHeap
    {
        bool isEmpty();
        int size();
        void insert(int element);
        int getTop(); // return and remove top element from heap
    }
}
