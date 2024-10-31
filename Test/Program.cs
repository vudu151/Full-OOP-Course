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
using Test.src.DesignPatterns.Creational.Buider.Good;
using Test.src.DesignPatterns.Creational.Builder.Bad;
using Test.src.DesignPatterns.Creational.Builder.Components;
using Test.src.DesignPatterns.Creational.Builder.Good;
using Test.src.DesignPatterns.Structural.Adapter;
using Test.src.DesignPatterns.Structural.Adapter.Package;
using Test.src.DesignPatterns.Structural.Composite;
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
// ////3. Design pattern - Creational
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
// var os = OperatingSystemType.Windows;
// IUIComponentFactory uIComponentFactory;

// if(os == OperatingSystemType.Windows){
//     uIComponentFactory = new WindowsUIComponentFactory();
// } else if(os == OperatingSystemType.Mac){
//     uIComponentFactory = new MacUIComponentFactory();
// } else{
//     throw new Exception("Unknown operating system");
// }

// new UserSettingsForm().Render(uIComponentFactory);

// //3.4. Builder pattern
////Bad
// var sportsCar = new Car(CarType.Sports, 2, false, new Engine(), new Dashboard(hasRevCounter: true), new Wheels(diameterInInches: 20), new GPSNavigator());
// sportsCar.Fuel = 100;

// var suvCar = new Car(CarType.SUV, 5, false, new Engine(), new Dashboard(hasRevCounter: true), new Wheels(diameterInInches: 19), new GPSNavigator());
// sportsCar.Fuel = 40;

// var sportsCarManual = new Manual(CarType.Sports, 2, false, new Engine(), new Dashboard(hasRevCounter: true), new Wheels(diameterInInches: 20), new GPSNavigator());
// System.Console.WriteLine(sportsCarManual.Print());

// var suvManual = new Manual(CarType.SUV, 5, false, new Engine(), new Dashboard(hasRevCounter: true), new Wheels(diameterInInches: 19), new GPSNavigator());
// System.Console.WriteLine(suvManual.Print());

////Good 1
// var carBuilder = new CarBuilder();
// carBuilder.SetCarType(CarType.Sports)
//     .SetSeats(2)
//     .SetEngine(new Engine())
//     .SetDashboard(new Dashboard(hasRevCounter: true))
//     .SetWheels(new Wheels(diameterInInches: 20));
// var sportsCar = carBuilder.GetCar();
// sportsCar.Fuel = 100;

// var manualBuilder = new CarManualBuilder();
// manualBuilder.SetCarType(CarType.Sports)
//     .SetSeats(2)
//     .SetEngine(new Engine())
//     .SetDashboard(new Dashboard(hasRevCounter: true))
//     .SetWheels(new Wheels(diameterInInches: 20));
// var sportsCarManual = manualBuilder.GetManual();
// System.Console.WriteLine(sportsCarManual.Print());

////Good 2
// var carBuilder = new CarBuilder();
// var director = new Director();

// director.ConstructorSportCar(carBuilder); 
// var sportsCar = carBuilder.GetCar();
// sportsCar.Fuel = 100;

// director.ConstructorSUV(carBuilder);
// var suvCar = carBuilder.GetCar();
// suvCar.Fuel = 40;

// var manualBuilder = new CarManualBuilder();
// director.ConstructorSportCar(manualBuilder);
// var sportsCarManual = manualBuilder.GetManual(); 
// System.Console.WriteLine(sportsCarManual.Print());

// director.ConstructorSUV(manualBuilder);
// var suvManual = manualBuilder.GetManual(); 
// System.Console.WriteLine(suvManual.Print());

//--------------------------------------------------------------
// ////3. Design pattern - Structural
////3.1. Composite Pattern
// var package = new Box();

// var box1 = new Box();   
// box1.Add(new Microphone());

// var box2 = new Box();   //box2 contains box3 and box4 contains

// var box3 = new Box();
// box3.Add(new Mouse());
// var box4 = new Box();
// box4.Add(new Keyboard());

// System.Console.WriteLine("Total price of package =" + package.GetPrice());
// box2.Add(box3);
// box2.Add(box4);

// package.Add(box1);
// package.Add(box2);

////3.2. Adapter Pattern
var videoEditor = new VideoEditor(new Video());
videoEditor.ApplyColor(new RainbowColor(new Rainbow()));