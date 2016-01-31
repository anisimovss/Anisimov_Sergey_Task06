namespace Library1
{
    internal interface IMyList<T>
    {
        void Append(T element);                 //добавить элемент в список
        void Delete(int index);                 //удалить элемент из списка
        T Get(int index);                       //взять элемент по индексу 
        void Insert(T element, int index);      //вставить элемент в список
        int Find(T element);                    //найти индекс элемента
    }
}