using NUnit.Framework;
using DataStructures.LinkedList;

namespace LinkedListTests
{
    public class Tests
    {
        [TestCase(new int[] { 1, 9, 3 }, new int[] { 1, 9, 3, 4 }, 4)]
        [TestCase(new int[] { }, new int[] { 6 }, 6)]
        [TestCase(new int[] { 7 }, new int[] { 7, 4 }, 4)]
        [TestCase(new int[] { 1, 7, 4, 3 }, new int[] { 1, 7, 4, 3, 7 }, 7)]

        public void AddTests(int[] array, int[] expectedArray, int value)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.Add(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 8, 3 }, new int[] { 1, 8, 3, 4 }, new int[] { 4 })]
        [TestCase(new int[] { }, new int[] { 4, 5, 6 }, new int[] { 4, 5, 6 })]
        [TestCase(new int[] { 1 }, new int[] { 1 }, new int[] { })]
        [TestCase(new int[] { 1, 9, 3 }, new int[] { 1, 9, 3, 7, 0 }, new int[] { 7, 0 })]

        public void AddArrayTests(int[] array, int[] expectedArray, int[] addArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.Add(addArray);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 5, 3 }, new int[] { 4, 1, 5, 3 }, 4)]
        [TestCase(new int[] { }, new int[] { 4 }, 4)]
        [TestCase(new int[] { 5 }, new int[] { 4, 5 }, 4)]
        [TestCase(new int[] { 1, 7, 4, 3 }, new int[] { 7, 1, 7, 4, 3 }, 7)]
        [TestCase(new int[] { 2 }, new int[] { 4, 2 }, 4)]
        public void AddFirstTests(int[] array, int[] expectedArray, int value)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.AddFirst(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 9, 3 }, new int[] { 4, 1, 9, 3 }, new int[] { 4 })]
        [TestCase(new int[] { 0 }, new int[] { 4, 5, 6, 0 }, new int[] { 4, 5, 6 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 9, 5, 1, 2, 3 }, new int[] { 9, 5 })]
        [TestCase(new int[] { }, new int[] { 3 }, new int[] { 3 })]

        public void AddArrayFirstTests(int[] array, int[] expectedArray, int[] addArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.AddFirst(addArray);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 9, 4, 5 }, 0, 1)]
        [TestCase(new int[] { 1, 2, 8, 4, 5 }, 2, 8)]
        [TestCase(new int[] { 1, 2, 4, 4, 5 }, 4, 5)]      

        public void GetByIndexTest(int[] array, int index, int expected)
        {
            LinkedList linkedList = new LinkedList(array);

            int actual = linkedList[index];

            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1,2,9,5,4,6,8 }, -1)]
        [TestCase(new int[] { 1, 2, 3, 9, 4, 6, 8 }, 7)]

        public void GetByIndexTestNegative(int[] array, int index)
        {
            try { 
            LinkedList linkedList = new LinkedList(array);
                int actual = linkedList[index] ;
                int expected = array[index];
                Assert.AreEqual(actual, expected);
            }
            catch
            { 
                Assert.Pass();
            }
            Assert.Fail();
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, 8, new int[] { 8, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, 10, new int[] { 1, 2, 10, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, -9, new int[] { 1, 2, 3, 4, -9 })]
        
        public void SetByIndex(int[] array, int index, int value, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);
            actual[index] = value;

            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1,0,3,4 }, -1,0)]

        public void SetByIndexNegative(int[] array, int index, int value)
        {
                LinkedList linkedList = new LinkedList(array);
                int actual = linkedList[index];
                int expected = value;
            try
            {
                Assert.AreEqual(actual, expected);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, int.MaxValue, new int[] { int.MaxValue, 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, 10, new int[] { 1, 2, 10, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, -9, new int[] { 1, 2, 3, 4, -9, 5 })]
        
        public void AddByIndex(int[] array, int index, int value, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);
            actual.AddByIndex(index, value);

            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, new int[] { int.MaxValue, 6, 7 }, new int[] { int.MaxValue, 6, 7, 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 10, 11 }, new int[] { 1, 2, 10, 11, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, new int[] { -9 }, new int[] { 1, 2, 3, 4, -9, 5 })]
        [TestCase(new int[] { 1 }, 0, new int[] { 0, 2, 3 }, new int[] { 0, 2, 3, 1 })]
        [TestCase(new int[] { }, 0, new int[] { 0 }, new int[] { 0 })]
        public void AddArrayByIndex(int[] array, int index, int[] addArray, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);
            actual.AddByIndex(index, addArray);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 1, 4, 3 }, new int[] { 1, 4 })]
        [TestCase(new int[] { 4}, new int[] {  })]
        [TestCase(new int[] { 1, 7, 5, 3 }, new int[] { 1, 7, 5 })]
        [TestCase(new int[] { 1}, new int[] { })]

        public void RemoveTests(int[] array, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.Remove();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { }, new int[] { })]

        public void RemoveTestsNegative(int[] array, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            try { expected.Remove(); }
            catch { Assert.Pass(); }
            Assert.Fail();
        }
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1},2)]
        [TestCase(new int[] { 4 }, new int[] { },1)]
        [TestCase(new int[] { 1, 8, 2, 3 }, new int[] { 1, 8, 2 },1)]
       

        public void RemoveQuantityTests(int[] array, int[] expectedArray,int quantity)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.Remove(quantity);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { }, new int[] { },0)]
        [TestCase(new int[] { }, new int[] { },1)]

        public void RemoveTestsNegative(int[] array, int[] expectedArray,int quantity)
        {
            LinkedList expected = new LinkedList(expectedArray);
            try { expected.Remove(quantity); }
            catch { Assert.Pass(); }
            Assert.Fail();
        }
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2,3 })]
        [TestCase(new int[] { 4 }, new int[] { })]
        [TestCase(new int[] { 1, 7, 2, 3 }, new int[] { 7, 2,3 })]
       

        public void RemoveFirstTests(int[] array, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.RemoveFirst();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3 }, 2)]
        [TestCase(new int[] { 4 }, new int[] { }, 1)]
        [TestCase(new int[] { 1, 7, 3, 3 }, new int[] {7, 3,3 }, 1)]
        
        public void RemoveFirstQuantityTests(int[] array, int[] expectedArray, int quantity)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.RemoveFirst(quantity);
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5}, 0)]
        [TestCase(new int[] {6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 }, new int[] {7,8, 9, 10, 11, 12, 13, 14, 15, 16, 17 }, 0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5}, new int[] { 1, 2, 4, 5}, 2)]
        
        public void RemoveByIndexTests(int[] array, int[] expectedArray, int index)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.RemoveByIndex(index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 }, new int[] { 11, 12, 13, 14, 15, 16, 17 }, 0, 10)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 }, new int[] { 1, 12, 13, 14, 15, 16, 17 }, 1, 10)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 }, new int[] { 1, 2, 13,14, 15, 16, 17 }, 2, 10)]
       

        public void RemoveQuantityByIndexTests(int[] array, int[] expectedArray, int index, int quantity)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.RemoveByIndex(index, quantity);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 10, 2, 3, 4, 5, 6, 7 }, 0, 10)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 10 }, 7, 10)]
        [TestCase(new int[] {  }, new int[] { 1}, 0, 1)]

        public void ChangeValueByIndex(int[] array, int[] expectedArray, int index, int value)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.ChangeByIndex(index, value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { },  -1,10)]

        public void ChangeValueByIndexNegative(int[] array,  int index, int value)
        {
            LinkedList actual = new LinkedList(array);
            try
            {
                actual.ChangeByIndex(index, value);
            }
            catch { Assert.Pass(); }
            Assert.Fail();
        }
        [TestCase(new int[] { 7, 2, 3, 4, 5 }, 0, 7)]
        [TestCase(new int[] { 1, 2, 9, 4, 5 }, 2, 9)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, 0, -1)]
        [TestCase(new int[] { 8 }, 0, 8)]
        public void GetValueByIndex(int[] array, int index, int expected)
        {

            LinkedList linkedList = new LinkedList(array);
            int actual = linkedList.GetValueByIndex(index);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { }, 0, 0)]
        public void GetValueByIndexNegative(int[] array, int index, int expected)
        {
            LinkedList linkedList = new LinkedList(array);
            try 
            { 
                linkedList.GetValueByIndex(index);
            }
            catch 
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, 2)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, 3)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, -4, 3)]
        [TestCase(new int[] { 1 }, 1, 0)]
        public void GetIndexByValue(int[] array, int value, int expected)
        {

            LinkedList linkedList = new LinkedList(array);
            int actual = linkedList.GetIndexByValue(value);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { }, 0, 0)]
        public void GetIndexByValueNegative(int[] array, int value, int expected)
        {
            LinkedList linkedList = new LinkedList(array);
            try
            {
                linkedList.GetIndexByValue(value);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        [TestCase(new int []{ 1, 2, 3 },new int[] { 3, 2, 1 })]
        [TestCase(new int[] { 1, 7, 3,4 }, new int[] {4, 3, 7, 1 })]
        [TestCase(new int[] { 1, 2, 5,4,5 }, new int[] {5,4, 5, 2, 1 })]
        public void ReversTests(int[]array,int[]expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new  LinkedList(array);
            actual.Revers();

            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { }, new int[] { })]
        public void ReversTestsNegative(int[] array, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            try
            {
                actual.Revers();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 }, 17)]
        [TestCase(new int[] { 1, 122, 12, 13, 14, 15, 16, 17 }, 122)]
        [TestCase(new int[] { 1, 2, 32, 13, 14, 15, 16, 17 }, 32)]
        [TestCase(new int[] { 11, 12, 13, 1555, 15, 16, 17 }, 1555)]
        public void FindMaxTest(int[] array,  int expected)
        {
            LinkedList linkedList = new LinkedList(array);
            int actual=linkedList.FindMax();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 111, 12, -13, 14, 15, 16, 17 }, -13)]
        [TestCase(new int[] { 1, 2, -32, 13, 14, 15, 16, 17 }, -32)]
        [TestCase(new int[] { 11, 12, 13, 1401, 15, 16, 17 }, 11)]


        public void FindMinTest(int[] array, int expected)
        {
            LinkedList linkedList = new LinkedList(array);
            int actual = linkedList.FindMin();
            Assert.AreEqual(expected, actual);
        }
      
        [TestCase(new int[] { 1, 111, 12, 13, 14, 15, 16, 17 }, 1)]
        [TestCase(new int[] { 1, 2, 32, 13, 14, 15, 16, 17 }, 2)]
        [TestCase(new int[] { 11, 12, 13, 1401, 15, 16, 17 }, 3)]


        public void FindIndexOfMaxTest(int[] array, int expected)
        {
            LinkedList linkedList = new LinkedList(array);
            int actual = linkedList.FindIndexOfMax();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 111, 12, -13, 14, 15, 16, 17 }, 3)]
        [TestCase(new int[] { 1, 2, -32, 13, 14, 15, 16, 17 }, 2)]
        [TestCase(new int[] { 11, 12, 13, 1401, 15, 16, 17 }, 0)]


        public void FindIndexOfMinTest(int[] array, int expected)
        {
            LinkedList linkedList = new LinkedList(array);
            int actual = linkedList.FindIndexOfMin();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 4,1,2,3},new int[] { 1,2,3,4})]
        [TestCase(new int[] { 9,7,6,4,3,1,8,5,2 }, new int[] { 1, 2, 3, 4,5,6,7,8,9 })]
        [TestCase(new int[] { -2,-4,-6,-8,-1,-3,-7,-9,-5 }, new int[] {-9,-8,-7,-6,-5,-4,-3,-2,-1 })]
        
        public void SortInAscendingOrderTest(int[]array,int[]expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.SortInAscendingOrder();
            Assert.AreEqual(expected,actual);
        }
        [TestCase(new int[] { 4, 1, 2, 3 }, new int[] { 4,3,2,1 })]
        [TestCase(new int[] { 9, 7, 6, 4, 3, 1, 8, 5, 2 }, new int[] { 9,8,7,6,5,4,3,2,1 })]
        [TestCase(new int[] { -2, -4, -6, -8, -1, -3, -7, -9, -5 }, new int[] { -1,-2,-3,-4,-5,-6,-7,-8,-9 })]
       
        public void SortInDescendingOrderTest(int[] array, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.SortInDescendingOrder();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 4,4,2,3,1 }, new int[] { 4,2,3,1 },4)]
        [TestCase(new int[] {5,8,7,9,4,6,1,4,4,4,7,8,0 }, new int[] { 5, 8, 7, 9,  6, 1,4,  4, 4, 7, 8, 0 },4)]
        [TestCase(new int[] { -2, -4, -6, -8, -1, -3,-8, -7, -9 ,-5}, new int[] { -2, -4, -6,  -1, -3, -8,-7, -9, -5 },-8)]
        
        public void RemoveFirstValueTest(int[] array, int[] expectedArray,int value)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.RemoveFirstValue(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 4, 4, 2, 3, 1 }, new int[] {  2, 3, 1 }, 4)]
        [TestCase(new int[] { 5, 8, 7, 9, 4, 6, 1, 4, 4, 4, 7, 8, 0 }, new int[] { 5, 8, 7, 9,  6, 1,  7, 8, 0 }, 4)]
        [TestCase(new int[] { -2,2,1,4,5,6,6,6,8,7,8,9,6,6,6,0 }, new int[] { -2, 2, 1, 4, 5, 8, 7, 8, 9,  0 }, 6)]
        [TestCase(new int[] { 10, 25, int.MaxValue, 12, int.MaxValue, 2, 3, int.MinValue }, new int[] { 10, 25,  12,  2, 3, int.MinValue }, int.MaxValue)]
        public void RemoveAllValueTest(int[] array, int[] expectedArray, int value)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.RemoveAllValue(value);
            Assert.AreEqual(expected, actual);
        }
    }
}