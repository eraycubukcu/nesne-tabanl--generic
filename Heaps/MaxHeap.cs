using Abstracts;

namespace Heaps;

public class MaxHeap<T> : Heap<T> where T:IComparable<T> // tipi kısıtladık
{
    public override T Extract()
    {
        var max = _innerList.Max();
        _innerList.Remove(max);
        return max ;
    }
}