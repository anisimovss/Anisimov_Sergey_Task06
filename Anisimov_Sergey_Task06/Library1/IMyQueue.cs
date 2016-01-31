namespace Library1
{
    internal interface IMyQueue<T>
    {
        void InQueue(T element);    //Добавить в очередь
        T DeQueue();                //Выйти из очереди
    }
}