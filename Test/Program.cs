using Test.src.OOPPrinciples.Abstraction;
using Test.src.OOPPrinciples.Coupling;
using Test.src.OOPPrinciples.Encapsultaion;
//using Test.src.OOPPrinciples.Inheritance;
//using Test.src.OOPPrinciples.Polymorphism;
using Test.src.OOPPrinciples.Composition;

// //1.Encapsulation (Tinh dong goi)
// BankAccount bankAccount = new BankAccount(100);
// System.Console.WriteLine(bankAccount.GetBalance());

// bankAccount.Deposit(50);        //Tien gui
// System.Console.WriteLine(bankAccount.GetBalance());

// bankAccount.Withdraw(200);      //Tien rut
// System.Console.WriteLine(bankAccount.GetBalance());


// //2.Abstraction
// //Reduce complexity by hiding unnecessary details
// EmailService emailService = new EmailService();
// emailService.SendMail();


// //3.Inheritance
// var car = new Car();
// //Shared
// car.Brand = "Ford";
// car.Start();
// car.Stop();

// //Unique
// car.NumberOfDoors = 4;

// //4. Polymorphism is the ability of an object to take many forms.
// List<Vehicle> vehicles = new List<Vehicle>();
// vehicles.Add(new Car{Brand = "Toyota", Model = "Camry", Year = 2020, NumberOfDoors = 4});
// vehicles.Add(new Motorcycle{Brand = "Harly", Model = "Camry", Year = 2020});

// //Vehicle inspection
// foreach(var vehicle in vehicles){
//     vehicle.Start();
// }

// //5.Coupling
// //var order = new Order(new EmailSender());
// var order = new Order(new SMSSender());
// order.PlaceOrder();

//6.Composition
var car = new Car();
car.StartCar();