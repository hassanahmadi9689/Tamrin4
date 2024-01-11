namespace ConsoleApp80;

public static class Management
{
    private static List<Car> _cars = new();
    private static List<User> _users = new List<User>();

    public static void AddRentalCar(string name, int price, int count)
    {
        var car = new RentalCar(name);
        car.setCount(count);
        car.setPrice(price);
        _cars.Add(car);
    }

    public static void AddUser(string name)
    {
        var user = new User(name);
        _users.Add(user);
    }

    public static void UpdatePrice(string name,int price)
    {
        var car = _cars.Find(_ => _.Name == name);
        if (car is null)
        {
            throw new Exception("car not found");
        }
        car.setPrice(price);
    }

    public static void RentCar(string username, string carname)
    {
        var user = _users.Find(_ => _.UserName == username);
        var car = _cars.Find(_ => _.Name == carname);
        var rentcar = car as RentalCar;
        rentcar.Rent();
        user.SetRent(car);
    }

    public static List<Car> GetCars()
    {
        return _cars;
    }

    public static void showRentUser(string username)
    {
        var user = _users.Find(_users => _users.UserName == username);
        
        foreach (var item in user.GetUserRentCars() )
        {
            Console.WriteLine($"user:{item.User} - car:{item.Car} - price:{item.Price}");
        }
    }
}