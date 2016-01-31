using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public class ListArr<T> : IMyList<T>
    {

        private T[] arr;

        //public int Max { get; set; }

        private int current;

        public void Append(T element)
        {
            // if (Current < Max)
            // {
            if (current == arr.Length) Array.Resize(ref arr, arr.Length + 5);
            arr[current] = element;
            current++;
            // }
        }

        /*public object Clone()
        {
            return new ListArr<T> { arr = this.arr, current = this.current };
        }*/

        public void Delete(int index)
        {
            if (index < current)
            {
                for (int i = index; i < current - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[current - 1] = default(T);
                current--;
            }
        }

        public int Find(T element)
        {
            for (int i = 0; i < current; i++)
            {
                if (((IComparable)(arr[i])).CompareTo(element) == 0) return (i);
            }
            throw new Exception("Элемент не существует в списке.");
        }

        public T Get(int index)
        {
            if (index < current) return (arr[index]);
            throw new Exception("Индекс элемента превышает количество элементов.");
        }

        public void Insert(T element, int index)
        {
            //if (Current < Max)
            //{
            if (current == arr.Length) Array.Resize(ref arr, arr.Length + 5);
            for (int i = current; i > index; i--) arr[i] = arr[i - 1];
            arr[index] = element;
            current++;
            //}
        }

        public ListArr()
        {
            current = 0;
            //Max = 100;
            arr = new T[5];
        }
    }
}

