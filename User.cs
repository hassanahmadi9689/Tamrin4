namespace ConsoleApp80;

public class User
{
    public User(string userName)
    {
        UserName = userName;
        _userRentCars = new List<UserRentCar>();
    }
    public string UserName { get; set; }

    private List<UserRentCar> _userRentCars;


public List<UserRentCar> GetUserRentCars()
    { 
        return _userRentCars;
    }

    public  void SetRent(Car car)
    {
        _userRentCars.Add(new UserRentCar(this,car.Name,car.Price));
    }

}

public class UserRentCar
{
    public UserRentCar(User user, string car, int price)
    {
        User = user;
        Car = car;
        Price = price;
        DateTime=DateTime.Now;
    }
    public User User { get; set; }
    public string Car { get; set; }
    public int Price { get; set; }
    public DateTime DateTime { get; set; }
}