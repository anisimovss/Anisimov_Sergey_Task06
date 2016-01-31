using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public class ListRef<T> : IMyList<T>
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

        public void Append(T element)
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

        public void Delete(int index)
        {
            Cell first = head;
            if (head != null)
            {
                if (index == 0) head = head.Next;
                else
                {
                    int i = 1;
                    while (first.Next != null)
                    {
                        if (index == i)
                        {
                            first.Next = first.Next.Next;
                            break;
                        }
                        else
                        {
                            first = first.Next;
                            i++;
                        }
                    }
                }
            }
            else Console.WriteLine("Список пуст.");
        }

        public int Find(T element)
        {
            Cell first = head;
            int i = 0;
            while (first != null)
            {
                if (((IComparable)(first.Data)).CompareTo(element) == 0) return (i);
                else first = first.Next;
                i++;
            }
            Console.WriteLine("Элемент не существует в списке.");
            return default(int);
            //throw new Exception("Элемент не существует в списке.");
        }

        public T Get(int index)
        {
            if (head != null)
            {
                Cell first = head;
                int i = 0;
                while (i != index)
                {
                    i++;
                    first = first.Next;
                }
                if (first == null)
                {
                    Console.WriteLine("Элемента с таким индексом не существует.");
                    return default(T);
                }
                return first.Data;
            }
            else
            {
                Console.WriteLine("Список пуст.");
                return default(T);
                //throw new Exception("Список пуст.");
            }
        }

        public void Insert(T element, int index)
        {
            Cell first = head;
            for (int i = 0; i < index-1; i++)
            {
                first = first.Next;
            }
            if (first != null)
            {
                Cell second = new Cell(element);
                second.Next = first.Next;
                first.Next = second;
                while (first != null)
                {
                    first = first.Next;
                    tail = first;
                } 
            }
        }

        public ListRef()
        {
            tail = null;
            head = null;
        }
    }
}
