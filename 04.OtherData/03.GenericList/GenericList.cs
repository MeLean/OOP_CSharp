namespace _03.GenericList
{
    using System;
    using System.Linq;
    using System.Runtime.InteropServices;

    [Version(2, 0)]
    public class GenericList<T> where T : IComparable<T>
    {
        private const int DefCapacity = 16;
        
        private T[] elements;
        private int elementsCount = 0;
        private int capacity;

        public GenericList(int capacity = DefCapacity)
        {
            this.elements = new T[capacity];
            this.Capacity = capacity;
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            set
            {
                if (value > 0)
                {
                    this.capacity = value;
                }
                else
                {
                    throw new ArgumentException("Capacity must be greater than zero!");
                }
            }
        }

        public int Count
        {
            get { return this.elementsCount; }
        }

        public void Add(T element)
        {
            if (this.elementsCount < this.capacity)
            {
                this.elements[this.elementsCount] = element;
                this.elementsCount++;
            }
            else
            {
                this.CapacityGrow();
                this.Add(element);
            }
        }

        public T GetElementAt(int index)
        {
            return this.elements[index];
        }

        public void RemoveElementAt(int index)
        {
            T[] result = new T[this.elementsCount - 1];

            int count = 0;
            for (int i = 0; i < this.elementsCount; i++)
            {
                if (i != index)
                {
                    result[count] = this.elements[i];
                    count++;
                }
            }

            this.elementsCount = this.elementsCount - 1;
            this.elements = result;
        }

        public void InsertElementAt(T element, int index)
        {
            if (index >= 0 && index <= this.elementsCount)
            {
                if (this.elementsCount + 1 > this.capacity)
                {
                    this.CapacityGrow();
                }
            }
            else
            {
                    throw new ArgumentException("Invalid index");
            }

            T[] result = new T[this.elementsCount + 1];
            
            for (int i = 0; i < index; i++)
            {
                result[i] = this.elements[i];
            }

            result[index] = element;

            for (int j = index; j < this.elementsCount; j++)
            {
                result[j + 1] = this.elements[j];
            }

            this.elements = result; 
            this.elementsCount++;
        }

        public void Clear()
        {
            this.elements = new T[this.capacity];
            this.elementsCount = 0;
        }

        public int IndexOf(T element)
        {
            int index = -1;
            for (int i = 0; i < this.elementsCount; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public bool Contains(T element)
        {
            if (this.IndexOf(element) != -1)
            {
                return true;
            }

            return false;
        }

        public T Max()
        {
            if (this.elementsCount < 1)
            {
                throw new InvalidComObjectException("The list is empty!");
            }

            T max = this.elements[0];

            for (int i = 1; i < this.elementsCount; i++)
            {
                if (this.elements[i].CompareTo(max) > 0)
                {
                    max = this.elements[i];
                }
            }

            return max;
        }
        
        public T Min()
        {
            if (this.elementsCount < 1)
            {
                throw new InvalidComObjectException("The list is empty!");
            }

            T min = this.elements[0];

            for (int i = 1; i < this.elementsCount; i++)
            {
                if (this.elements[i].CompareTo(min) < 0)
                {
                    min = this.elements[i];
                }
            }

            return min;
        }

        public override string ToString()
        {
            return string.Join(", ", this.elements.Take(this.elementsCount).ToArray());
        }

        private void CapacityGrow()
        {
            this.capacity = this.capacity * 2;
            T[] growList = new T[this.capacity];

            for (int i = 0; i < this.elementsCount; i++)
            {
                growList[i] = this.elements[i];
            }

            this.elements = growList;
        }
    }
}