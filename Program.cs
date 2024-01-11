// See https://aka.ms/new-console-template for more information

using ConsoleApp80;

while (true)
{
    try
    {
        Run();

    }
    catch (Exception exception)
    {
        ShowError(exception.Message);
    }
}

static void Run()
{
    var Option = GetNumberFromUser("Choose option:\n" +
                                   "1.Add Rental Car\n" +
                                   "2.Add User\n" +
                                   "3.Show Car\n" +
                                   "4.update price\n" +
                                   "5.Rent Car\n" +
                                   "6.show user rent car");
    switch (Option)
    {
        case 1:
        {
            var name = GetValidStringFromUser("enter name of car");
            var count = GetNumberFromUser("enter count of this car:");
            var price = GetNumberFromUser("enter price");
            Management.AddRentalCar(name,price,count);
            break;
        }
        case 2:
        {
            var username = GetValidStringFromUser("enter name of user");
            Management.AddUser(username);
            break;
        }
        case 3:
        {
            foreach (var car in Management.GetCars())
            {
                        Console.WriteLine($"name : {car.Name} - count: {car.Count} - price:{car.Price}");
            }
            break;
        }
        case 4:
        {
            var carname = GetValidStringFromUser("enter name of car");
            var Newprice = GetNumberFromUser("enter new price");
            Management.UpdatePrice(carname,Newprice);
            break;
        }
        case 5:
        {
            var carname = GetValidStringFromUser("enter name of car");
            var username = GetValidStringFromUser("enter name of user");
            Management.RentCar(username,carname);
            break;
        }
        case 6:
        {
            var username = GetValidStringFromUser("enter username");
            Management.showRentUser(username);
            break;
        }
            
        
    }

}



static string GetValidStringFromUser(string message)
{
    bool tryparse = false;
    string? value;
    do
    {
        Console.WriteLine(message);
        value = Console.ReadLine();
          
    } while ( string.IsNullOrWhiteSpace(value)   );
 
    return value;
}

static int GetNumberFromUser(string message)
{
    var resultTryParseFirstNumber = false;
    int number;
    do
    {
        Console.WriteLine(message);
        resultTryParseFirstNumber =
            int.TryParse(Console.ReadLine(), out number);
    } while (!resultTryParseFirstNumber );

    return number;
}

static void ShowError(string error)
{
    Console.WriteLine("*********");
    Console.WriteLine(error);
    Console.WriteLine("*********");
}