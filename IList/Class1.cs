using System;

namespace DataStructures
{
    public interface IList
    {
        void Add(int value);
        void Add(int[] a);
        void AddFirst(int value);
        void AddFirst(int[] array);
        void AddByIndex(int index, int value);
        void AddByIndex(int index, int[] array);
        void Remove();
        void Remove(int quantity);
        void RemoveFirst();
        void RemoveFirst(int quantity);
        void RemoveByIndex(int index);
        void RemoveByIndex(int index, int quantity);
        int GetLength();
        int GetValueByIndex(int index);
        int GetIndexByValue(int value);
        void ChangeByIndex(int index, int value);
        void Reverse();
        int FindMaxValue();
        int FindMinValue();
        int FindIndexOfMaxValue();
        int FindIndexOfMinValue();
        void InsertionSortAscendingOrder();
        void InsertionSortDescendingOrder();
        void RemoveByValueFirst(int value);
        void RemoveByValueAll(int value);
        void ShowArrayList();
        void ShowArrayList(int[] a);
    }
}
