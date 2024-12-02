using Abstracts;

namespace Heaps ;

public abstract class Heap<T> : IHeap<T> where T: IComparable<T> // tipi kısıtladık
{
    protected List<T> _innerList ;
    public Heap()
    {
        _innerList = new List<T>();
    }
    public int Count => _innerList.Count;

    public void Add(T item)
    {
        _innerList.Add(item);
    }

    public abstract T Extract();
}