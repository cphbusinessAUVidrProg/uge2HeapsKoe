using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uge2Heaps
{
    class Program
    {
        static void Main(string[] args)
        {
            IIntHeap myHeap = new GoodHeap();
            myHeap.insert(17);
            myHeap.insert(8);
            myHeap.insert(4);
            myHeap.insert(77);
            myHeap.insert(12);
            while(!myHeap.isEmpty())
            {
                Console.WriteLine(myHeap.getTop());
            }
            Console.ReadLine();
        }
    }
}
