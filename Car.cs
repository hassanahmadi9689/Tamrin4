namespace ConsoleApp80;

public abstract class Car
{
   protected Car(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
    public int Price { get; private set; }
    public int Count { get; private set; }

    public virtual void setPrice(int price)
    {
        if (price<0)
        {
            throw new Exception("price cant be negative");
        }

        Price = price;
    }

    public virtual void setCount(int count)
    {
        if (count<0)
        {
            throw new Exception("count cant be negative");
        }

        Count = count;
    }
}

public class RentalCar : Car
{
    public RentalCar(string name) : base(name)
    {
        
    }

    public void Rent()
    {
        if (Count==0)
        {
            throw new Exception("car has been finished");
        }

        var newcount = Count - 1;
        setCount(newcount);
    }

    
    
}
