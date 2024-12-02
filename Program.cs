using Abstracts;
using Entities;
using Heaps;
// istenilen type verilebilir
IHeap<Product> heap = new MaxHeap<Product>();

heap.Add(new Product(){Id=1 , Name = "Laptop" , Price =25_000 });
heap.Add(new Product(){Id=2 , Name = "Mouse" , Price =5_000 });
heap.Add(new Product(){Id=3 , Name = "Keyboard" , Price =5_200 });
heap.Add(new Product(){Id=4 , Name = "iPad" , Price =28_000 });
heap.Add(new Product(){Id=5 , Name = "AirPod" , Price =7_000 });


while (heap.Count>0)
{
    System.Console.WriteLine(heap.Extract());
}
