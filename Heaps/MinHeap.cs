using Abstracts;

namespace Heaps ;

public class MinHeap<T> :  Heap<T> where T:IComparable<T> // tipi kısıtladık
{
    public override T Extract()
    {
        var min = _innerList.Min();
        _innerList.Remove(min);
        return min ;
    }
}