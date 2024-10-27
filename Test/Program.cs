// using Test.src.OOPPrinciples.Abstraction;
// using Test.src.OOPPrinciples.Coupling;
// using Test.src.OOPPrinciples.Encapsultaion;
//using Test.src.OOPPrinciples.Inheritance;
//using Test.src.OOPPrinciples.Polymorphism;
//using Test.src.OOPPrinciples.Composition;
// using System.Drawing;
// using Test.src.SOLID.L;
// using Test.src.SOLID.I;
// using Test.src.SOLID.D;
//using Test.src.DesignPatterns.Creational.Prototype;
using Test.src.DesignPatterns.Creational.AbstractFactory;
//using Test.src.DesignPatterns.Creational.Singleton.Good;

// //1.Encapsulation (Tinh dong goi)
// //1.1.Encapsulation (Tinh dong goi)
// BankAccount bankAccount = new BankAccount(100);
// System.Console.WriteLine(bankAccount.GetBalance());

// bankAccount.Deposit(50);        //Tien gui
// System.Console.WriteLine(bankAccount.GetBalance());

// bankAccount.Withdraw(200);      //Tien rut
// System.Console.WriteLine(bankAccount.GetBalance());


// //1.2 :Abstraction
// //Reduce complexity by hiding unnecessary details
// EmailService emailService = new EmailService();
// emailService.SendMail();


// //1.3: Inheritance
// var car = new Car();
// //Shared
// car.Brand = "Ford";
// car.Start();
// car.Stop();

// //Unique
// car.NumberOfDoors = 4;

// //1.4 : Polymorphism is the ability of an object to take many forms.
// List<Vehicle> vehicles = new List<Vehicle>();
// vehicles.Add(new Car{Brand = "Toyota", Model = "Camry", Year = 2020, NumberOfDoors = 4});
// vehicles.Add(new Motorcycle{Brand = "Harly", Model = "Camry", Year = 2020});

// //Vehicle inspection
// foreach(var vehicle in vehicles){
//     vehicle.Start();
// }

// //1.5 : Coupling
// //var order = new Order(new EmailSender());
// var order = new Order(new SMSSender());
// order.PlaceOrder();

// //1.6 : Composition
// var car = new Car();
// car.StartCar();

////2. SOLID
//2.1 : L
// var rec = new Test.src.SOLID.L.Square();
// rec.Height = 10;
// rec.Width = 5;
// System.Console.WriteLine("Expected area = 10  * 5 = 50");
// System.Console.WriteLine("Calculate area =" + rec.Area);

// Shape rect = new Test.src.SOLID.L.Rectangle {Width = 5, Height = 4};
// System.Console.WriteLine($"Area of the rectangle {rect.Area}");

// Shape square = new Test.src.SOLID.L.Square {SideLength = 5};
// System.Console.WriteLine($"Area of the square {square.Area}");

// //C
// var circle = new Circle();
// circle.Radius = 10;
// System.Console.WriteLine(circle.Area());

// //D
// var car = new Car(new Engine());

// ////3. Design pattern 
// //3.1: Prototype pattern
// var circle = new Circle();
// circle.Draw();

// circle.Radius = 12;     //user clicks and drags to resize

// var rectangle = new Rectangle();
// rectangle.Draw();

// rectangle.Width = 20;   //user clicks and drags rectangle to resize
// rectangle.Height = 12;

// //user right-click and selecting "duplicate"
// var shapeAction = new ShapeAction();
// Shape newCircle = shapeAction.Duplicate(circle);
// newCircle.Draw();

// Shape newRectangle = shapeAction.Duplicate(rectangle);
// newRectangle.Draw();

// //3.2: Singleton pattern
// var setting = AppSettings.GetInstance();
// setting.Set("app_name", "Design pattern");
// setting.Set("app_creator", "Design pattern creator");
// System.Console.WriteLine(setting.Get("app_name"));
// TestSingletonGood.Run();
// //TestSingleton.Run();

// //3.3: AbstractFactory pattern
var os = OperatingSystemType.Windows;
IUIComponentFactory uIComponentFactory;

if(os == OperatingSystemType.Windows){
    uIComponentFactory = new WindowsUIComponentFactory();
} else if(os == OperatingSystemType.Mac){
    uIComponentFactory = new MacUIComponentFactory();
} else{
    throw new Exception("Unknown operating system");
}

new UserSettingsForm().Render(uIComponentFactory);