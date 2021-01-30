using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;


namespace DataStructures
{
    public class ArrayList
    {
        public int Length { get; private set; }
        private int[] _array;

        public ArrayList()
        {
            _array = new int[1];
            Length = 0;
        }
        public ArrayList(int a)
        {
            _array = new int[1] { a };
            Length = 1;
        }
        public ArrayList(int[] a)
        {
            _array = a;
            Length = a.Length;
        }
        private void IncreaseLength(int number = 1)
        {
            int newLenght = _array.Length;
            while (newLenght <= _array.Length + number)
            {
                newLenght = (int)(newLenght * 1.33 + 1);
            }

            int[] newArray = new int[newLenght];
            Array.Copy(_array, newArray, _array.Length);

            _array = newArray;
        }
        private void ReductionLength(int number=1)
        {
            
            int newLenght = _array.Length ;
            while (newLenght*0.75 >= Length)
            {
                newLenght = (int)(newLenght -number);
            }

            int[] newArray = new int[newLenght];
            Array.Copy(_array, newArray, Length - 1);

            _array = newArray;
        }
        //1
        public void Add(int value)
        {
            if (Length <= _array.Length)
            {
                IncreaseLength();
            }
            _array[Length] = value;
            Length++;

        }
        //21
        public void Add(int[] a)
        {
            
                while (Length + a.Length > _array.Length)
                {
                    IncreaseLength();
                }
            
            for (int i = 0; i < a.Length; i++)
            {
                _array[Length + i] = a[i];
            }

            Length += a.Length;
        }
        //2
        public void AddFirst(int value)
        {
            if (Length < _array.Length)
            {
                IncreaseLength();
            }
            int[] tempArray = new int [_array.Length+1];
            for (int i = 0; i <_array.Length; i++)
            { 
                tempArray[i+1] = _array[i];
            }
            tempArray[0] = value;
            _array = tempArray;
            Length++;
        }
        //22
        public void AddFirst(int[] array)
        {
            while (Length + array.Length > _array.Length)
            {
                IncreaseLength();
            }

            Length += array.Length;
            int[] newArray = new int[Length];
            for (int i = 0; i < Length - array.Length; i++)
            {
                newArray[i + array.Length] = _array[i];
            }
            _array = newArray;

            for (int i = 0; i < array.Length; i++)
            {
                _array[i] = array[i];
            }
        }
        //3
        public void AddByIndex(int index, int value)
        {
            if (index < 0)
                throw new IndexOutOfRangeException("Index can't be negative");
            if (index > Length)
                throw new IndexOutOfRangeException("List doesn't contain an element with this index");
            while (Length >= _array.Length)
            {
                IncreaseLength();
            }
            for (int i = Length - 1; i >= index; i--)
            {
                _array[i + 1] = _array[i];
            }
            _array[index] = value;
            Length++;
        }
        //23 
        public void AddByIndex(int index, int[] array)
        {
            int arrayLength = array.Length;
            if (index < 0)
                throw new IndexOutOfRangeException("Index can not be negative");
            if (index > Length)
                throw new IndexOutOfRangeException("List does not contain an element with this index");
            while (Length >= _array.Length || Length + arrayLength > _array.Length)
            {
                IncreaseLength(arrayLength);
            }
            for (int i = Length - 1; i >= index; i--)
            {
                _array[i + arrayLength] = _array[i];
            }
            for (int i = 0; i < arrayLength; i++)
            {
                _array[i + index] = array[i];
            }
            Length += arrayLength;
        }
        //4
        public void Remove()
        {
            if (Length > 0)
            {
                ReductionLength();
                Length--;
            }
        }
        //24
        public void Remove (int quantity)
        {
            if (Length <= 0)
            {
                throw new Exception("Nothing to remove");
            }
                        if (quantity <= 0)
            {
                throw new Exception("Please enter a positive number");
            }
            while (quantity != 0)
            {
                Remove();
                quantity--;
            }
        }
        //5
        public void RemoveFirst()
        {
            if (_array.Length > 0)
            {
                int[] newArray = new int[_array.Length];
                for (int i = 0; i < _array.Length - 1; i++)
                {
                    newArray[i] = _array[i + 1];
                }
                _array = newArray;

               // ReductionLength();
                Length--;
            }
        }
        //25 
        public void RemoveFirst(int quantity)
        {
            if (Length <= 0)
            {
                throw new Exception("Nothing to remove");
            }
            else if (_array.Length/2 >= Length)
            {
                ReductionLength();
            }
            if (quantity <= 0)
            {
                throw new Exception("Please enter a positive number");
            }
            while (quantity != 0)
            {
                RemoveFirst();
                quantity--;
            }
           
        }
        //6
        public void RemoveByIndex(int index)
        {
                if (Length <= 0)
                {
                    throw new IndexOutOfRangeException();
                }
            
            if ((Length > 0) && (index < _array.Length) && (index >= 0))
            {
                int[] newArray = new int[Length];
                newArray = _array;
                for (int i = index; i < Length-1 ; i++)
                {
                        newArray[i] = _array[i + 1];
                }
                if (_array.Length / 2 >= Length)
                {
                    ReductionLength();
                }
                _array = newArray;
                Length--;
            }
        }
        //26
        public void RemoveByIndex(int index, int quantity)
        {
            if (Length <= 0)
            {
                throw new Exception("Nothing to remove");
            }
            if (quantity <= 0)
            {
                throw new Exception("Please enter a positive number");
            }
            if (index == 0)
            {
                RemoveFirst(quantity);
            }
            else
            {
                while (quantity != 0)
                {
                    RemoveByIndex(index);
                    quantity--;
                }
            }
        }
        //7
        public int GetLength()
        {
            int a = _array.Length;
            return a;
        }
        //8
        public int GetValueByIndex(int index)
        {
            bool check = false;
            int value = 0;

            for (int i = 0; i < _array.Length; i++)
            {
                if (i == index)
                {
                    value = _array[i];
                    check = true;
                    break;
                }
            }
            if (check == true)
            {
                return value;
            }
            else
            {
                throw new Exception("Value doesn't exist");
            }
        }
        //9
        public int GetIndexByValue(int value)
        {
            bool check = false;
            int index = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == value)
                {
                    index = i;
                    check = true;
                }
            }
            if (check == true)
            {
                return index;
            }
            else
            {
                throw new Exception("Value doesn't exist");
            }
        }
        //10
        public void ChangeByIndex(int index, int value)
        {
            if (Length < _array.Length)
            {
                IncreaseLength();
            }
            for (int i = 0; i < _array.Length; i++)
            {
                if (index == i)
                {
                    _array[i] = value;
                }
            }
        }
        //11
        public void Reverse()
        {
            for (int i = 0, j = GetLength() - 1; i < j; i++, j--)
            {
                int temp = _array[i];
                _array[i] = _array[j];
                _array[j] = temp;
            }
        }
        //12
        public int FindMaxValue()
        {
            int max = _array[0];
            for (int i = 0; i < GetLength(); i++)
            {
                if (max < _array[i])
                    max = _array[i];
            }
            return max;
        }
        //13
        public int FindMinValue()
        {
            int min = _array[0];
            for (int i = 0; i < GetLength(); i++)
            {
                if (min > _array[i])
                    min = _array[i];
            }
            return min;
        }
        //14
        public int FindIndexOfMaxValue()
        {
            int max = _array[0];
            int index = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (max <= _array[i])
                {
                    max = _array[i];
                    index = i;
                }
            }
            return index;
        }
        //15
        public int FindIndexOfMinValue()
        {
            int min = _array[0];
            int index = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (min >= _array[i])
                {
                    min = _array[i];
                    index = i;
                }
            }
            return index;
        }
        //16
        public void InsertionSortAscendingOrder()
        {
            for (int i = 1; i < _array.Length; i++)
            {
                for (int j = i; j > 0 && _array[j - 1] > _array[j]; j--)
                {
                    int temp = _array[j - 1];
                    _array[j - 1] = _array[j];
                    _array[j] = temp;
                }
            }
        }
        //17
        public void InsertionSortDescendingOrder()
        {
            for (int i = 1; i < _array.Length; i++)
            {
                for (int j = i; j > 0 && _array[j - 1] < _array[j]; j--)
                {
                    int temp = _array[j - 1];
                    _array[j - 1] = _array[j];
                    _array[j] = temp;
                }
            }
        }
        //18
        public void RemoveByValueFirst(int value)
        {

            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    RemoveByIndex(i);
                    i--;
                }
            }
            
        }
        //19
        public void RemoveByValueAll(int value)
        {

            int valueCount = 0;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    valueCount++;
                }
            }
            while (valueCount != 0)
            {
                for (int i = 0; i < Length; i++)
                {
                    if (_array[i] == value)
                    {
                        RemoveByIndex(i);
                        valueCount--;
                    }
                }
            }
        }
        public override bool Equals(object obj)
        {
            ArrayList arrayList = (ArrayList)obj;

            if (Length != arrayList.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < Length; i++)
                {
                    if (_array[i] != arrayList._array[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public void ShowArrayList()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                Console.Write(_array[i] + " ");
            }

        }
        public void ShowArrayList(int []a)
        {
            a = _array;
            _array = a;
            for (int i = 0; i < _array.Length; i++)
            {
                Console.Write(_array[i] + " ");
            }

        }
        public override string ToString()
        {
            return string.Join(";", _array.Length);
        }
    }
}
