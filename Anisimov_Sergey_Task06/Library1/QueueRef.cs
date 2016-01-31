using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public class QueueRef<T> : IMyQueue<T>
    {
        private class Cell
        {
            public T Data { get; set; }
            public Cell Next { get; set; }
            public Cell(T newElement)
            {
                Data = newElement;
                Next = null;
            }
        }

        private Cell head;

        private Cell tail;

        public T DeQueue()
        {
            if (head == null)
            {
                Console.WriteLine("Стек пуст.");
                return default(T);
                //throw new Exception("Очередь пуста.");
            }
            else
            {
                Cell first = head;
                head = head.Next;
                if (head == null) tail = null;
                return first.Data;
            }
        }

        public void InQueue(T element)
        {
            Cell first = new Cell(element);
            if (head == null)
            {
                head = first;
                tail = first;
            }
            else
            {
                tail.Next = first;
                tail = first;
            }
        }

        public QueueRef()
        {
            head = null;
            tail = null;
        }
    }
}
