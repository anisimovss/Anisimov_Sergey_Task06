namespace Library1
{
    internal interface IMyStack<T>
    {
        void Push(T element);   //добавить элемент в стек
        T Pop();                //выдать элемент из стека

    }
}