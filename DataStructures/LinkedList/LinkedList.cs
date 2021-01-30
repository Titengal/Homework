using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{

    public class LinkedList
    {
        public int Length { get; private set; }
        private Node _root;
        public LinkedList()
        {
            Length = 0;
            _root = null;
        }
        public LinkedList(int[] array)
        {
            Length = array.Length;

            if (array.Length != 0)
            {
                _root = new Node(array[0]);
                Node tmp = _root;
                for (int i = 1; i < array.Length; i++)
                {
                    tmp.Next = new Node(array[i]);
                    tmp = tmp.Next;
                }
            }
            else
            {
                _root = null;
            }
        }
        public int this[int index]
        {
            get
            {
                Node tmp = _root;
                for (int i = 0; i < index; i++)
                {
                    tmp = tmp.Next;
                }
                return tmp.Value;
            }

            set
            {
                Node tmp = _root;
                for (int i = 0; i < index; i++)
                {
                    tmp = tmp.Next;
                }
                tmp.Value = value;
            }
        }
        public void Add(int value)
        {
            if (Length == 0)
            {
                Node newNode = new Node(value);
                _root = newNode;
                newNode.Next = null;
                Length = 1;
            }
            else
            {
                Node tmp = _root;
                for (int i = 0; i < Length - 1; i++)
                    tmp = tmp.Next;
                Node newNode = new Node(value);
                tmp.Next = newNode;
                Length++;
            }
        }
        public void Add(int []addArray)
        {
            if (Length == 0 && addArray.Length != 0)
                _root = new Node(addArray[0]);

            Node tmp = _root;
            for (int i = 0; i < Length - 1; i++)
            {
                tmp = tmp.Next;
            }
            for (int i = 0; i < addArray.Length; i++)
            {
                tmp.Next = new Node(addArray[i]);
                tmp = tmp.Next;
            }

            if (Length == 0 && addArray.Length != 0)
                _root = _root.Next;

            Length += addArray.Length;
        }
        public void AddFirst(int value)
        {
            Node current = new Node(value);
            current.Next = _root;
            _root = current;
            Length++;
        }
        public void AddFirst(int[] addArray)
        {
            int i = addArray.Length - 1;
            while (i != -1)
            {
                AddFirst(addArray[i]);
                i--;
            }
        }
        public void AddByIndex(int index, int value)
        {
            if (index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (index != 0)
            {
                Node current = _root;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                Node tmp = new Node(value);
                tmp.Next = current.Next;
                current.Next = tmp;
            }
            else
            {
                Node tmp = new Node(value);
                tmp.Next = _root;
                _root = tmp;
            }
            Length++;
        }
        public void AddByIndex(int index, int[] array)
        {
            Node current;
            Node tmp;
            if (_root != null)
            {
                if (Length <= index)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    if (index == 0)
                    {
                        current = new Node(array[0]);
                        tmp = current;
                        for (int i = 1; i < array.Length; i++)
                        {
                            current.Next = new Node(array[i]);
                            current = current.Next;
                        }
                        current.Next = _root;
                        _root = tmp;
                        Length += array.Length;
                    }
                    else
                    {
                        current = _root;
                        for (int i = 0; i < index - 1; i++) current = current.Next;
                        Node tmp2 = new Node(array[0]);
                        tmp = current.Next;
                        current.Next = tmp2;
                        for (int i = 1; i < array.Length; i++)
                        {
                            tmp2.Next = new Node(array[i]);
                            tmp2 = tmp2.Next;
                        }
                        tmp2.Next = tmp;
                        Length += array.Length;
                    }
                }
            }
            else if (_root == null && index == 0 && array.Length != 0)
            {
                _root = new Node(array[0]);
                current = _root;
                for (int i = 1; i < array.Length; i++)
                {
                    current.Next = new Node(array[i]);
                    current = current.Next;
                }
                Length = array.Length;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void Remove()
        {
            if (Length == 0)
            {
                throw new Exception("Nothing to remove");
            }
            else
            {
                Node tmp = _root;
                for (int i = 0; i < Length - 2; i++)
                {
                    tmp = tmp.Next;
                }
                tmp.Next = null;
                Length--;
            }
        }
        public void Remove(int quantity)
        {
            if (Length == 0)
            {
                throw new Exception("Nothing to remove");
            }
            else
            {
                while(quantity!=0)
                {
                    Remove();
                    quantity--;
                }
            }
        }
        public void RemoveFirst()
        {
            if (Length == 0)
            {
                throw new Exception("Nothing to remove");
            }
            else
            {
                
                Node tmp = _root;
                _root = tmp.Next;
                for (int i = 0; i < Length - 2; i++)
                {
                    _root= tmp.Next;
                }
                tmp = null;
                Length--;
            }
        }
        public void RemoveFirst(int quantity)
        {
            if (Length == 0)
            {
                throw new Exception("Nothing to remove"); 
            }
            else
            {
                while (quantity != 0)
                {
                    RemoveFirst();
                    quantity--;
                }
            }
        }
        public void RemoveByIndex(int index)
        {
            if (index<0||index>Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (index == 0)
            {
                RemoveFirst();
            }
            else if (index == Length)
            {
                Remove();
            }
            else 
            {
                Node tmp = _root;
                for (int i = 2; i <= index; i++)
                {
                    tmp = tmp.Next;
                }
                Node current = tmp.Next;
                current = current.Next;
                tmp.Next = current;
                Length--;
            }
        }
        public void RemoveByIndex(int index,int quantity)
        {
            if (index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException();
            }
            while (quantity!=0)
            {
                RemoveByIndex(index);
                quantity--;
            }
        }
        public void ChangeByIndex (int index, int value)
        {
            if (Length < index||index<0)
            {
                throw new IndexOutOfRangeException();
            }
            if (Length==0)
            {
                Add(value);
            }
            if (index==0)
            {
                RemoveFirst();
                AddFirst(value);
            }
            if (index==Length)
            {
                Remove();
                Add(value);
            }
            else
            {
                    Node tmp = _root;
                for (int i = 0; i < Length; i++)
                {
                    if (i == index)
                    {
                        tmp.Value = value;
                    }
                    tmp = tmp.Next;
                }
            }
        }
        public int GetValueByIndex(int index)
        {
            bool check = false;
            int value = 0;
            for (int i = 0; i < Length; i++)
            {
                Node current = _root;
                if (i == index)
                {
                    value = current.Value;
                    check = true;
                    break;
                }
                _root = current.Next;
            }
            if (check == true)
            {
                return value;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public int GetIndexByValue(int value)
        {
            bool check = false;
            int index = 0;
            for (int i = 0; i < Length; i++)
            {
                Node current = _root;
                if (current.Value == value)
                {
                    index = i;
                    check = true;
                    break;
                }
                _root = current.Next;
            }
            if (check == true)
            {
                return index;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void Revers ()
        {
            if (Length<=0)
            {
                throw new ArgumentNullException();
            }
            Node current = _root;
            Node prev = null;
            Node next;
            while (current.Next != null)
            {
               
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            current.Next = prev;
            _root = current;
        }
        public int FindMax()
        {
            Node tmp = _root;
            int b = tmp.Value;
            for (int i = 0; i < Length; i++)
            {
                if (tmp.Value > b)
                { 
                    b = tmp.Value;
                }
                tmp = tmp.Next;
            }
            return b;
        }
        public int FindMin()
        {
            Node tmp = _root;
            int b = tmp.Value;
            for (int i = 0; i < Length; i++)
            {
                if (tmp.Value < b)
                { 
                    b = tmp.Value;
                }
                tmp = tmp.Next;
            }
            return b;
        }
        public int FindIndexOfMax()
        {
            Node tmp = _root;
            int b = tmp.Value;
            int index=0;

            for (int i = 0; i < Length; i++)
            {
                if (tmp.Value > b) 
                { 
                    b = tmp.Value;
                    index = i;
                }
                tmp = tmp.Next;
            }
            return index;
        }
        public int FindIndexOfMin()
        {
            Node tmp = _root;
            int b = tmp.Value;
            int index = 0;

            for (int i = 0; i < Length; i++)
            {
                if (tmp.Value < b)
                {
                    b = tmp.Value;
                    index = i;
                }
                tmp = tmp.Next;
            }
            return index;
        }
        public void SortInAscendingOrder()
        {
            for (int i = 0; i < Length; i++)
            {
                Node current = _root;
                for (int j = 1; j < Length - i; j++)
                {
                    if (current.Value > current.Next.Value)
                    {
                        int tmp = current.Next.Value;
                        current.Next.Value = current.Value;
                        current.Value = tmp;
                    }
                    current = current.Next;
                }
            }
        }
        public void SortInDescendingOrder()
        {
            for (int i = 0; i < Length; i++)
            {
                Node current = _root;
                for (int j = 1; j < Length - i; j++)
                {
                    if (current.Value <current.Next.Value)
                    {
                        int tmp = current.Next.Value;
                        current.Next.Value = current.Value;
                        current.Value = tmp;
                    }
                    current = current.Next;
                }
            }
        }
        public void RemoveFirstValue(int value)
        {
            if (Length != 0)
            {
                Node tmp = _root;
                while (tmp.Next.Value != value && tmp.Next != null)
                {
                    tmp = tmp.Next;
                }
                tmp.Next = tmp.Next.Next;
                Length--;
            }
        }
        public void RemoveAllValue(int value)
        {
            Node previous = null;
            Node current = _root;
            while (current != null)
            {
                if (current.Value == value && previous == null)
                {
                    _root = current.Next;
                    Length--;
                }
                else if (current.Value == value)
                {
                    previous.Next = current.Next;
                    Length--;
                }
                else
                {
                    previous = current;
                }
                current = current.Next;
            }
        }
        public override bool Equals(object obj)
        {
            LinkedList linkedList = (LinkedList)obj;

            if (Length != linkedList.Length)
            {
                return false;
            }

            Node tmp1 = _root;
            Node tmp2 = linkedList._root;

            for (int i = 0; i < Length; i++)
            {
                if (tmp1.Value != tmp2.Value)
                {
                    return false;
                }
                tmp1 = tmp1.Next;
                tmp2 = tmp2.Next;
            }
            return true;
        }
        public override string ToString()
        {
            string s = "";

            Node tmp = _root;
            for (int i = 0; i < Length; i++)
            {
                s += tmp.Value + ";";
                tmp = tmp.Next;
            }
            return s;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public int GetLength()
        {
            return Length;
        }
    }
}

