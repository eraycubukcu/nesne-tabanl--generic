namespace Entities ;

public class Product : IComparable<Product>
{
    public int Id { get; set; }
    public String Name { get; set; }
    public Decimal Price { get; set; }

    public int CompareTo(Product? other)
    {
        return this.Price.CompareTo(other.Price);
    }
    public override string ToString()
    {
        return $"{Name,-15} {Price:c}";
    }
}