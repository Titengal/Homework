using NUnit.Framework;
using DataStructures.DoubleLinkedList;
using System;

namespace DoubleLinkedListTests
{
    public class Tests
    {
        [TestCase(new int[] { 1, 9, 3 }, new int[] { 1, 9, 3, 4 }, 4)]
        [TestCase(new int[] { }, new int[] { 6 }, 6)]
        [TestCase(new int[] { 7 }, new int[] { 7, 4 }, 4)]
        [TestCase(new int[] { 1, 7, 4, 3 }, new int[] { 1, 7, 4, 3, 7 }, 7)]

        public void AddTests(int[] array, int[] expectedArray, int value)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.Add(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 8, 3 }, new int[] { 1, 8, 3, 4 }, new int[] { 4 })]
        [TestCase(new int[] { }, new int[] { 4, 5, 6 }, new int[] { 4, 5, 6 })]
        [TestCase(new int[] { 1 }, new int[] { 1 }, new int[] { })]
        [TestCase(new int[] { 1, 9, 3 }, new int[] { 1, 9, 3, 7, 0 }, new int[] { 7, 0 })]
        public void AddArrayTests(int[] array, int[] expectedArray, int[] addArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
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
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.AddFirst(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 9, 3 }, new int[] { 4, 1, 9, 3 }, new int[] { 4 })]
        [TestCase(new int[] { 0 }, new int[] { 4, 5, 6, 0 }, new int[] { 4, 5, 6 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 9, 5, 1, 2, 3 }, new int[] { 9, 5 })]
        [TestCase(new int[] { }, new int[] { 3 }, new int[] { 3 })]
        

        public void AddArrayFirstTests(int[] array, int[] expectedArray, int[] addArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.AddFirst(addArray);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 9, 4, 5 }, 0, 8, new int[] { 8, 1, 2, 9, 4, 5 })]
        [TestCase(new int[] { 1, 2, 8, 4, 5 }, 2, 10, new int[] { 1, 2, 10, 8, 4, 5 })]
        [TestCase(new int[] { 1, 2, 4, 4, 5 }, 4, -9, new int[] { 1, 2, 4, 4, -9, 5 })]
        
        public void AddByIndexTests(int[] array, int index, int value, int[] expArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.AddByIndex(index, value);

            Assert.AreEqual(expected, actual);

        }
 
        [TestCase(new int[] { 1, 2, 3, 7, 5 }, 4, new int[] { -9 }, new int[] { 1, 2, 3, 7, -9, 5 })]
        [TestCase(new int[] { 1 }, 0, new int[] { 0, 2, 3 }, new int[] { 0, 2, 3, 1 })]
        [TestCase(new int[] { }, 0, new int[] { 0 }, new int[] { 0 })]
        public void AddArrayByIndexTest(int[] array, int index, int[] addArray, int[] expArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.AddByIndex(index, addArray);

            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 4, 3, 4, 5 },  new int[] { 1, 4, 3, 4 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 },  new int[] { -1, -2, -3, -4  })]
        [TestCase(new int[] { 1 },  new int[] {  })]
        public void RemoveTests(int[] array,  int[] expArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.Remove();

            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] {  }, new int[] { })]
        public void RemoveTestsNegative(int[] array, int[] expArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(array);
            try
            {
                actual.Remove(); 
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();

        }
        [TestCase(new int[] { 1, 2, 7, 4, 5 }, new int[] { 1, 2, 7 },2)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, new int[] { -1, -2 },3)]
        [TestCase(new int[] { 2 }, new int[] { },1)]
        

        public void RemoveArrayTests(int[] array, int[] expArray,int quantity
            )
        {
            DoubleLinkedList expected = new DoubleLinkedList(expArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.Remove(quantity);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1,2}, new int[] { },3)]
        [TestCase(new int[] {  }, new int[] { }, 3)]

        public void RemoveArrayTestsNegative(int[] array, int[] expArray,int quantity)
        {
            DoubleLinkedList actual = new DoubleLinkedList(array);
            try
            {
                actual.Remove(quantity);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();

        }
        [TestCase(new int[] { 1, 2, 7, 4, 5 }, new int[] {  2, 7, 4 ,5})]
        [TestCase(new int[] { -1, -2, -9, -4, -5 }, new int[] {  -2, -9, -4,-5 })]
        [TestCase(new int[] { 1 }, new int[] { })]
        public void RemoveFirstTests(int[] array, int[] expArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.RemoveFirst();

            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { }, new int[] { })]
        public void RemoveFirstTestsNegative(int[] array, int[] expArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(array);
            try
            {
                actual.RemoveFirst();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();

        }
        [TestCase(new int[] { 1, 2, 8, 4, 5 }, new int[] {  8,4,5 }, 2)]
        [TestCase(new int[] { -1, -2, -4, -4, -5 }, new int[] { -4,-5 }, 3)]
        [TestCase(new int[] { 8 }, new int[] { }, 1)]
        

        public void RemoveFirstArrayTests(int[] array, int[] expArray, int quantity
            )
        {
            DoubleLinkedList expected = new DoubleLinkedList(expArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.RemoveFirst(quantity);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2 }, new int[] { }, 3)]
        [TestCase(new int[] { }, new int[] { }, 3)]

        public void RemoveFirstArrayTestsNegative(int[] array, int[] expArray, int quantity)
        {
            DoubleLinkedList actual = new DoubleLinkedList(array);
            try
            {
                actual.RemoveFirst(quantity);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();

        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5 },0)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, new int[] { -1,-2, -3, -4 },4)]
        [TestCase(new int[] { 1 }, new int[] { },0)]
        public void RemoveByIndexTests(int[] array, int[] expArray, int index)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.RemoveByIndex(index);

            Assert.AreEqual(expected, actual);

        }
        
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] {  4, 5 }, 0,3)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] {  }, 0,5)]
        [TestCase(new int[] { 1 }, new int[] { }, 0,1)]
        public void RemoveByIndexTests(int[] array, int[] expArray, int index, int quantity)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.RemoveByIndex(index,quantity);

            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { }, new int[] { }, 0, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5 }, 5, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5 }, -5, 1)]

        public void RemoveByIndexNegative(int[] array, int[] expArray, int index, int quantity)
        {
            DoubleLinkedList actual = new DoubleLinkedList(array);
            try
            {
                actual.RemoveByIndex(index, quantity);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
            [TestCase(new int[] { 9, 2, 3, 4, 5 }, 9, 0)]
            [TestCase(new int[] { 1, 2, 8, 4, 5 }, 8, 2)]
            [TestCase(new int[] { 1 }, 1, 0)]
            public void GetIndexByValueTest(int[] array, int value, int expected)
            {

                DoubleLinkedList doubleLinkedList = new DoubleLinkedList(array);
                int actual = doubleLinkedList.GetIndexByValue(value);

                Assert.AreEqual(expected, actual);
            }
            [TestCase(new int[] { }, 0, 0)]
            public void GetIndexByValueTestNegative(int[] array, int value, int expected)
            {
            DoubleLinkedList doubleLinkedList = new DoubleLinkedList(array);
            try
            {
                    doubleLinkedList.GetIndexByValue(value);
                }
                catch
                {
                    Assert.Pass();
                }
                Assert.Fail();
            }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 1, 2)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, 4)]
        [TestCase(new int[] { 1, 2, 3, 4, 6 }, 4, 6)]
        [TestCase(new int[] { 1 }, 0, 1)]
        public void GetValueByIndexTest(int[] array, int index, int expected)
        {

            DoubleLinkedList doubleLinkedList = new DoubleLinkedList(array);
            int actual = doubleLinkedList.GetValueByIndex(index);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { }, 0, 0)]
        [TestCase(new int[] { }, 0, -2)]
        [TestCase(new int[] { }, 0, 7)]

        public void GetValueByIndexTestNegative(int[] array, int index, int expected)
        {
            DoubleLinkedList doubleLinkedList = new DoubleLinkedList(array);
            try
            {
                doubleLinkedList.GetValueByIndex(index);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 4, 3, 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        public void ReverseTests(int[] array, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.Reverse();

            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { }, new int[] { })]
        public void ReversTestsNegative(int[] array, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            try
            {
                actual.Reverse();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, 12, new int[] { 1, 2, 12, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, -19, new int[] { 1, 2, 3, -19, 5 })]
        [TestCase(new int[] { 1 }, 0, 0, new int[] { 0 })]


        public void SetByIndexTest(int[] array, int index, int value, int[] expArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual[index] = value;
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] {  }, 0)]
        [TestCase(new int[] { 1 }, 1)]

        public void SetByIndexTestNegative(int[] array, int index )
        {
            DoubleLinkedList actual = new DoubleLinkedList(array);
            Assert.Throws<IndexOutOfRangeException>(() => actual[index] = 0);
        }
        [TestCase(new int[] { 1, 200, 12, 13, 14, 15, 16, 17 }, 200)]
        [TestCase(new int[] { 1, 2, 52, 13, 14, 15, 16, 17 }, 52)]
        [TestCase(new int[] { 11, 12, 13, 401, 15, 16, 17 }, 401)]
        public void FindMaxTest(int[] array, int expected)
        {
            DoubleLinkedList doubleLinkedList = new DoubleLinkedList(array);
            int actual = doubleLinkedList.FindMax();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, -8, 9, 10, 11, 12, 13, 14, 15, 16, 17 }, -8)]
        [TestCase(new int[] { 1, 111, 12, -13, 14, 15, 16, 17 }, -13)]
        [TestCase(new int[] { 1, 2, -32, 13, 14, 15, 16, 17 }, -32)]
        [TestCase(new int[] { 11, 12, 13, 1401, 15, 16, 17 }, 11)]


        public void FindMinTest(int[] array, int expected)
        {
            DoubleLinkedList doubleLinkedList = new DoubleLinkedList(array);
            int actual = doubleLinkedList.FindMin();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 20, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1 }, 4)]
        [TestCase(new int[] { 1, 155, 12, 13, 14, 15, 16, 17 }, 1)]
        [TestCase(new int[] { 1, 2, 32, 13, 14, 15, 16, 17 }, 2)]
        [TestCase(new int[] { 11, 12, 13, 101, 15, 16, 17 }, 3)]


        public void FindIndexOfMaxTest(int[] array, int expected)
        {
            DoubleLinkedList doubleLinkedList = new DoubleLinkedList(array);
            int actual = doubleLinkedList.FindIndexOfMax();
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(new int[] { 1, 111, 12, -3, 14, 15, 16, 17 }, 3)]
        [TestCase(new int[] { 1, 2, -2, 13, 14, 15, 16, 17 }, 2)]
        [TestCase(new int[] { 1, 12, 13, 1401, 15, 16, 17 }, 0)]

        public void FindIndexOfMinTest(int[] array, int expected)
        {
            DoubleLinkedList doubleLinkedList = new DoubleLinkedList(array);
            int actual = doubleLinkedList.FindIndexOfMin();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 4, 1, 2, 3 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 9, 7, 6, 4, 3, 1, 8, 5, 2 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
        [TestCase(new int[] { -2, -4, -6, -8, -1, -3, -7, -9, -5 }, new int[] { -9, -8, -7, -6, -5, -4, -3, -2, -1 })]
       

        public void SortInAscendingOrderTest(int[] array, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.SortInAscendingOrder();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 5, 1, 2, 3 }, new int[] { 5, 3, 2, 1 })]
        [TestCase(new int[] { 9, 7, 6, 4, 3, 1}, new int[] { 9, 7, 6, 4, 3,1 })]
        [TestCase(new int[] { -2, -4, -6, -8, -1}, new int[] { -1, -2, -4,-6, -8})]
       
        public void SortInDescendingOrderTest(int[] array, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.SortInDescendingOrder();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 4, 4, 2, 3, 1 }, new int[] { 4, 2, 3, 1 }, 4)]
        [TestCase(new int[] { 5, 8, 7, 9, 4, 6, 1}, new int[] { 5, 8, 7, 9, 6, 1}, 4)]
        [TestCase(new int[] { -2, -4, -6, -8, -1, -3 }, new int[] { -2, -4, -6, -1, -3}, -8)]

        public void RemoveFirstValueTest(int[] array, int[] expectedArray, int value)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.RemoveFirstValue(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] {  }, 4)]

        public void RemoveFirstValueTestNegative(int[] array, int value)
        {
            DoubleLinkedList actual = new DoubleLinkedList(array);
            try
            {
            actual.RemoveFirstValue(value);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        [TestCase(new int[] { 5, 5, 2, 3, 1 }, new int[] { 2, 3, 1 }, 5)]
        [TestCase(new int[] { 5, 8, 7, 9, 9, 6, 1, 9, 9, 9, 7, 8, 0 }, new int[] { 5, 8, 7, 6, 1, 7, 8, 0 }, 9)]
        [TestCase(new int[] { 8, 7, 8, 9, 6, 6, 6, 0 }, new int[] { 8, 7, 8, 9, 0 }, 6)]
       
        public void RemoveAllValueTest(int[] array, int[] expectedArray, int value)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.RemoveAllValue(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { }, 4)]

        public void RemoveAllValueTestNegative(int[] array, int value)
        {
            DoubleLinkedList actual = new DoubleLinkedList(array);
            try
            {
                actual.RemoveAllValue(value);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}
