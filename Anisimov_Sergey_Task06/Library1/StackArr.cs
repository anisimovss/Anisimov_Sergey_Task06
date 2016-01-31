using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public class StackArr<T> : IMyStack<T>
    {

        private T[] arr;

        //public int Max { get; set; }

        private int current;


        public T Pop()
        {
            if (current == 0)
            {
                Console.WriteLine("Стек пуст.");
                return default(T);
                //throw new Exception("Стек пуст");
            }
            else
            {
                current--;
                T tmp = arr[current];
                arr[current] = default(T);
                return tmp;
            }
        }

        public void Push(T element)
        {
            //if (Current < Max)
            //{
            if (current == arr.Length) Array.Resize(ref arr, arr.Length + 5);
            arr[current] = element;
            current++;
            //}
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public StackArr()
        {
            arr = new T[5];
            current = 0;
        }
    }
}
