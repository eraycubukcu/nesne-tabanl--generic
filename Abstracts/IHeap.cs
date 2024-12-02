namespace Abstracts;
public interface IHeap<T> where T:IComparable<T> // tipi kısıtladık
{
    int Count {get;}
    void Add(T item);
    T Extract();
}