using NUnit.Framework;
using DataStructures;
namespace DataStructures_Tests
{
    public class Tests
    {
        [TestCase(new int[] { 1, 7, 3, 4, 5 }, new int[] { 1, 7, 3, 4, 5, 6 }, 6)]
        [TestCase(new int[] { 1, 2, 3, 9, 5 }, new int[] { 1, 2, 3, 9, 5, 25 }, 25)]
        [TestCase(new int[] { 6, 2, 3, 4, 5 }, new int[] { 6, 2, 3, 4, 5, 0 }, 0)]
        [TestCase(new int[] { 4, 2, 3, 4, 5 }, new int[] { 4, 2, 3, 4, 5, -1 }, -1)]
        [TestCase(new int[] { }, new int[] { 6 }, 6)]
        public void AddTests(int[] array, int[] expectedArray, int value)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.Add(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 2, 1, 4, 5 }, new int[] { 2, 1, 4, 5, 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5, 101, 202, 203 }, new int[] { 101, 202, 203 })]
        [TestCase(new int[] { 2, 5, 4, 5 }, new int[] { 2, 5, 4, 5, -101, -102, 103 }, new int[] { -101, -102, 103 })]
        [TestCase(new int[] { 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5, 0, 303 }, new int[] { 0, 303 })]
        [TestCase(new int[] { 0 }, new int[] { 0, 1, 2, 3 }, new int[] { 1, 2, 3 })]
        public void AddArrayTests(int[] array, int[] expectedArray, int[] addArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.Add(addArray);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 0, 1, 2, 3, 4, 5 }, 0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 25, 1, 2, 3, 4, 5 }, 25)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 90, 1, 2, 3, 4, 5 }, 90)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { -1, 1, 2, 3, 4, 5 }, -1)]
        [TestCase(new int[] { }, new int[] { 6 }, 6)]
        public void AddFirstTests(int[] array, int[] expectedArray, int value)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.AddFirst(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 99, 98, 100, 1, 2, 3, 4, 5 }, new int[] { 99, 98, 100 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { -99, -98, -100, 1, 2, 3, 4, 5 }, new int[] { -99, -98, -100 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5, -1, 1, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5, -1 })]
        [TestCase(new int[] { 0,90 }, new int[] { 6, 7,0, 90 }, new int[] { 6, 7 })]
        public void AddArrayFirstTests(int[] array, int[] expectedArray, int[] addArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.AddFirst(addArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 0, 2, 3, 4, 5 }, 1, 0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 25, 4, 5 }, 3, 25)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 90, 5 }, 4, 90)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { -1, 1, 2, 3, 4, 5 }, 0, -1)]
        [TestCase(new int[] { }, new int[] { 6 }, 0, 6)]
        public void AddByIndexTest(int[] array, int[] expectedArray, int index, int value)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.AddByIndex(index, value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 0,0,0, 2, 3, 4, 5 }, 1,new int[] { 0,0,0})]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 0,0,0, 4, 5 }, 3, new int[] { 0, 0, 0 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 0,0,0, 5 }, 4, new int[] { 0, 0, 0 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 0,0,0, 1, 2, 3, 4, 5 }, 0, new int[] { 0, 0, 0 } )]
        [TestCase(new int[] { }, new int[] { 6,0 }, 0, new int[] { 6 ,0})]
        public void AddArrayByIndexTest(int[] array, int[] expectedArray, int index, int[] addAray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.AddByIndex(index, addAray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5,6 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3}, new int[] { 1, 2})]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2})]
        [TestCase(new int[] { 6}, new int[] {  })]
        public void RemoveTests(int[] array, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.Remove();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5 }, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 25 }, new int[] { 1, 2, 3,4 }, 2)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 0 }, new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, -1 }, new int[] { 1, 2 }, 4)]
        [TestCase(new int[] { 0,6 }, new int[] {0 }, 1)]
        public void RemoveQuantityTests(int[] array, int[] expectedArray, int quantity)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.Remove(quantity);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] {  2, 3, 4, 5,6 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2,3 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] {  2, 3,4 })]
        [TestCase(new int[] { 0,1, 2, 3 }, new int[] {  1,2,3 })]
        [TestCase(new int[] { 6,0 }, new int[] { 0})]
        public void RemoveFirstTests(int[] array, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.RemoveFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] {2, 3, 4, 5,6 }, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 25 }, new int[] { 3, 4,5,25 }, 2)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 0 }, new int[] { 4,5,0 }, 3)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, -1 }, new int[] { 5,-1 }, 4)]
        [TestCase(new int[] { 0, 6 }, new int[] { 6 }, 1)]
        public void RemoveQuantityFirstTests(int[] array, int[] expectedArray, int quantity)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.RemoveFirst(quantity);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 3, 4, 5, 6 }, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 25 }, new int[] { 1,2, 4, 5, 25 }, 2)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 0 }, new int[] { 1,2,3, 5, 0 }, 3)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, -1 }, new int[] { 1,2,3,4, -1 }, 4)]
        [TestCase(new int[] { 0, 6 }, new int[] { 0 }, 1)]
        public void RemoveByIndexTest(int[] array, int[] expectedArray, int index)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);
            actual.RemoveByIndex(index);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { },  0)]
        [TestCase(new int[] { },  5)]
        public void RemoveByIndexTestNegative(int[] array, int index)
        {
            ArrayList actual = new ArrayList(array);
            try { actual.RemoveByIndex(index); }
            catch { Assert.Pass(); }
            Assert.Fail();
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 4, 5, 6 }, 1, 2)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 25 }, new int[] { 1, 2, 25 }, 2, 3)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 0 }, new int[] { 1, 2, 3 }, 3, 3)]
        [TestCase(new int[] { 0, 6 }, new int[] { 0 }, 1, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] {1}, 1, 5)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 6 }, 0, 5)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] {  }, 0, 6)]


        public void RemoveQuantityByIndexTest(int[] array, int[] expectedArray, int index, int quantity)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);
            actual.RemoveByIndex(index, quantity);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { }, 0, 1)]
        [TestCase(new int[] { }, 5, 0)]
        public void RemoveQuantityByIndexTestNegative(int[] array, int index, int quantity)
        {
            ArrayList actual = new ArrayList(array);
            try { actual.RemoveByIndex(index, quantity); }
            catch { Assert.Pass(); }
            Assert.Fail();
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 1, 2)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 25 },5,25)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 0 },0,1) ]
        [TestCase(new int[] { 1, 2, 3, 4, 5, -1 },3,4)]

        public void GetValueByIndexTest(int[] array, int index, int expected)
        {
            ArrayList NewArrayList = new ArrayList(array);
            int actual = NewArrayList.GetValueByIndex(index);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 1, 0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 25 }, 5, 4)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 0 }, 0, 5)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, -1 }, 3, 2)]

        public void GetIndexByValueTest(int[] array, int value, int expected)
        {
            ArrayList NewArrayList = new ArrayList(array);
            int actual = NewArrayList.GetIndexByValue(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1,2,243,4,5,6 },2,243)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 243, 2, 3, 4, 5, 6 }, 0, 243)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 243 }, 5, 243)]
        [TestCase(new int[] {  }, new int[] { },0,0)]
        public void ChangeValueByIndexTest(int[] array, int[] expectedArray,int index,int value)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);
            actual.ChangeByIndex(index,value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] {6,5,4,3,2,1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 25 }, new int[] {25,5,4,3,2,1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 0 }, new int[] { 0,5,4,3,2,1 })]
        [TestCase(new int[] { 0, 6 }, new int[] { 6,0})]
        public void ReversTest(int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);
            actual.Reverse();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 6)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 25 }, 25)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 0 }, 5)]
        [TestCase(new int[] { 0, 6 },6)]
        public void FindMaxTest(int[] array, int expected)
        {
            ArrayList newArray = new ArrayList(array);
            int actual = newArray.FindMaxValue();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 25 }, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 0 }, 0)]
        [TestCase(new int[] { 0, 6 }, 0)]
        public void FindMinTest(int[] array, int expected)
        {
            ArrayList newArray = new ArrayList(array);
            int actual = newArray.FindMinValue();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 26 }, 5)]
        [TestCase(new int[] { 1, 2, 34, 4, 5, 25 }, 2)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 0 }, 4)]
        [TestCase(new int[] { 0, 6 }, 1)]
        public void FindIndexOfMaxTest(int[] array, int expected)
        {
            ArrayList newArray = new ArrayList(array);
            int actual = newArray.FindIndexOfMaxValue();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, -25 }, 5)]
        [TestCase(new int[] { 1, 2, 3, -4, 5, 0 }, 3)]
        [TestCase(new int[] { 0, 6 }, 0)]
        public void FindIndexOfMinTest(int[] array, int expected)
        {
            ArrayList newArray = new ArrayList(array);
            int actual = newArray.FindIndexOfMinValue();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] {1,3,5,7,9,2,4,6,8  }, new int[] {1,2,3,4,5,6,7,8,9 })]
        [TestCase(new int[] { 2,1 }, new int[] { 1,2 })]
        [TestCase(new int[] {25,45,15,35,68,47 }, new int[] {15,25,35,45,47,68 })]
        [TestCase(new int[] {2,1,3  }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] {0  }, new int[] { 0 })]
        [TestCase(new int[] {  }, new int[] {  })]

        public void InsertionSortInAscendingOrderTests(int[] array, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.InsertionSortAscendingOrder();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 3, 5, 7, 9, 2, 4, 6, 8 }, new int[] { 9,8,7,6,5,4,3,2,1 })]
        [TestCase(new int[] { 2, 1 }, new int[] { 2,1 })]
        [TestCase(new int[] { 25, 45, 15, 35, 68, 47 }, new int[] { 68,47,45,35,25,15})]
        [TestCase(new int[] { 2, 1, 3 }, new int[] { 3,2,1 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { }, new int[] { })]

        public void InsertionSortInDescendingOrderTests(int[] array, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.InsertionSortDescendingOrder();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 2, 3, 4, 5, 6 }, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 25 }, new int[] { 1, 3, 4, 5, 25 }, 2)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 0 }, new int[] { 1, 2, 4, 5, 0 }, 3)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, -1 }, new int[] { 1, 2, 3, 5, -1 }, 4)]
        [TestCase(new int[] { 0, 6 }, new int[] { 0 },6)]
        [TestCase(new int[] { 0, 6,6 }, new int[] { 0 }, 6)]

        public void RemoveByValueFirstTest(int[] array, int[] expectedArray, int value)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);
            actual.RemoveByValueFirst(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2,1,1, 3,1,1, 4,1,1, 5, 6 }, new int[] { 2, 3, 4, 5, 6 }, 1)]
        [TestCase(new int[] { 1, 2, 3,2,2, 4,2,2, 5,2,2, 25 }, new int[] { 1, 3, 4, 5, 25 }, 2)]
        [TestCase(new int[] {3, 1,3, 2, 3, 4,3, 5, 3,0 ,3}, new int[] { 1, 2, 4, 5, 0 }, 3)]
        [TestCase(new int[] { 1,4, 2,4, 4,4,4,4,4,4,4,4,4,3, 4, 5, -1 }, new int[] { 1, 2, 3, 5, -1 }, 4)]
        [TestCase(new int[] { 0, 6 }, new int[] { 0 }, 6)]
        public void RemoveByValueAllTest(int[] array, int[] expectedArray, int value)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);
            actual.RemoveByValueAll(value);
            Assert.AreEqual(expected, actual);
        }
    }
    
}