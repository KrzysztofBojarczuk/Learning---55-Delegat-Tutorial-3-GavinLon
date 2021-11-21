// See https://aka.ms/new-console-template for more information
using Gevin;


CarFactoryDel carFactoryDel = CarFactory.ReturnICECar;

Car iceCar = carFactoryDel(1, "Audi R8");


carFactoryDel = CarFactory.ReturnEvCar;
Car evCar = carFactoryDel(2, "Tesla Model-3");

LogICECarDetailsDel logICECarDetailsDel = LogCarDetails;

logICECarDetailsDel(iceCar as ICECar);

LogEVCarDetailsDel logEVCarDetailsDel = LogCarDetails;

logEVCarDetailsDel(evCar as EVCar);

Console.WriteLine();


//Console.WriteLine($"Object type: {iceCar.GetType()}");
//Console.WriteLine($"Car Details: {iceCar.GetCarDetails()}");

//Console.WriteLine($"Object type: {evCar.GetType()}");
//Console.WriteLine($"Car Details: {evCar.GetCarDetails()}");

static void LogCarDetails(Car car)
{
    if (car is ICECar)
    {
        using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ICEDetails.txt"), true))
        {
            sw.WriteLine($"Object Type: {car.GetType()}");
            sw.WriteLine($"Car Detials: {car.GetCarDetails()}");
        }
    }
    else if (car is EVCar)
    {
        Console.WriteLine($"Object Type: {car.GetType()}");
        Console.WriteLine($"Car Detials: {car.GetCarDetails()}");
    }
    else
    {
        throw new ArgumentException();
    }

}

delegate Car CarFactoryDel(int id, string name);
delegate void LogICECarDetailsDel(ICECar car);
delegate void LogEVCarDetailsDel(EVCar car);