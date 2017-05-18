using Microsoft.VisualStudio.TestTools.UnitTesting;
using uge2Heaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uge2Heaps.Tests
{
    [TestClass()]
    public class GoodHeapTests
    {
        private IIntHeap theHeap;

        [TestInitialize()]
        public void initHeap()
        {
            theHeap = new GoodHeap();
        }

        [TestMethod()]
        public void GoodHeapTest()
        {
            Assert.IsTrue(theHeap.isEmpty());
        }

        [TestMethod()]
        public void getTopTestOne()
        {
            theHeap.insert(88);
            Assert.AreEqual(88, theHeap.getTop());
        }
        [TestMethod()]
        public void getTopTestTwoA()
        {
            IIntHeap myHeap = new GoodHeap();
            myHeap.insert(88);
            myHeap.insert(77);
            Assert.AreEqual(88, myHeap.getTop());
        }
        [TestMethod()]
        public void getTopTestTwoB()
        {
            IIntHeap myHeap = new GoodHeap();
            myHeap.insert(77);
            myHeap.insert(88);
            Assert.AreEqual(88, myHeap.getTop());
        }

        [TestMethod()]
        public void insertTest()
        {
            // testet i getTop
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void insertTestRigtigMange()
        {
            Random r = new Random();
            IIntHeap myHeap = new GoodHeap(2);
            int N = 20; // sikre at expand kaldes
            int max = -1;
            for( int i = 0; i < N; i++)
            {
                int elm = r.Next();
                max = Math.Max(max, elm);
                myHeap.insert(elm);
            }
            Assert.AreEqual(max, myHeap.getTop());
        }

        [TestMethod()]
        public void isEmptyTestTrue()
        {
            IIntHeap myHeap = new GoodHeap();
            Assert.IsTrue(myHeap.isEmpty());
        }
        [TestMethod()]
        public void isEmptyTestFalse()
        {
            IIntHeap myHeap = new GoodHeap();
            myHeap.insert(99);
            Assert.IsFalse(myHeap.isEmpty());
        }

        [TestMethod()]
        public void sizeTestEmpty()
        {
            Assert.IsTrue(true);//Magen til konstruktor
        }

        [TestMethod()]
        public void sizeTestOne()
        {
            IIntHeap myHeap = new GoodHeap();
            myHeap.insert(99);
            Assert.AreEqual(1, myHeap.size());
        }

        [TestMethod()]
        public void sizeTestDecrement()
        {
            IIntHeap myHeap = new GoodHeap();
            myHeap.insert(77);
            myHeap.insert(88);
            myHeap.getTop();
            Assert.AreEqual(1, myHeap.size());
        }

        [TestMethod()]
        public void getTopOrTest()
        {
            IIntHeap myHeap = new GoodHeap();
            int t = myHeap.getTopOr(-1);
            Assert.AreEqual(-1, t );
        }
        [TestMethod()]
        public void getTopOrTestOne()
        {
            IIntHeap myHeap = new GoodHeap();
            myHeap.insert(77);
            int t = myHeap.getTopOr(-1);
            Assert.AreEqual(77, t);
        }
    }
}