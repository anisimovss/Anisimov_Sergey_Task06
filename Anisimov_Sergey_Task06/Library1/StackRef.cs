using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public class StackRef<T> : IMyStack<T>
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

        public StackRef()
        {
            head = null;
        }

        public T Pop()
        {
            if (head == null)
            {
                Console.WriteLine("Стек пуст.");
                return default(T);
                //throw new Exception("Стек пуст");
            } 
            else
            {
                Cell first = head;
                head = first.Next;
                return first.Data;
            }
        }

        public void Push(T element)
        {
            Cell first = new Cell(element);
            first.Next = head;
            head = first;
        }
    }
}
