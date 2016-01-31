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

        public void Append(T element)
        {
            Cell first = new Cell(element);
            first.Next = head;
            head = first;
        }

        public void Delete(int index)
        {
            Cell first = head;
            if (head != null)
            {
                if (index == 0) head = head.Next;
                else
                {
                    int i = 0;
                    while (first.Next != null)
                    {
                        if (index == i)
                        {
                            first = first.Next.Next;
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
            else throw new Exception("Список пуст.");
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
            throw new Exception("Элемент не существует в списке.");
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
                return first.Data;
            }
            else throw new Exception("Список пуст.");
        }

        public void Insert(T element, int index)
        {
            Cell first = head;
            for (int i = 0; i < index; i++)
            {
                first = first.Next;
            }
            if (first != null)
            {
                Cell second = new Cell(element);
                second.Next = first.Next;
                first.Next = second;
            }
        }

        public ListRef()
        {
            head = null;
        }
    }
}
