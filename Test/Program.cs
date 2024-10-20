using Test.src.OOPPrinciples.Abstraction;
using Test.src.OOPPrinciples.Encapsultaion;
using Test.src.OOPPrinciples.Inheritance;

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


//3.Inheritance
var car = new Car();
//Shared
car.Brand = "Ford";
car.Start();
car.Stop();

//Unique
car.NumberOfDoors = 4;