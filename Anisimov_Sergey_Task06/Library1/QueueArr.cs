using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public class QueueArr<T> : IMyQueue<T>
    {

        private T[] arr;

        private int head;

        private int tail;

        public T DeQueue()
        {
            if (tail == head)
            {
                Console.WriteLine("Стек пуст.");
                return default(T);
                //throw new Exception("Очередь пуста.");
            }
            else
            {
                T tmp = arr[head];
                if (tail == 1)
                {
                    tail = head;
                    arr[head] = default(T);
                    return tmp;
                }
                tail--;
                for (int i = 0; i < tail; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[tail] = default(T);
                return tmp;
            }
        }

        public void InQueue(T element)
        {
            if (tail == arr.Length) Array.Resize(ref arr, arr.Length + 5);
            arr[tail] = element;
            tail++;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public QueueArr()
        {
            arr = new T[5];
            head = 0;
            tail = 0;
        }
    }
}
