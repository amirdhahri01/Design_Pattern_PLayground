﻿// using TestConsoleApp.src.OopPrinciples.Encapsulation;
// BadBankAccount badBankAccount = new BadBankAccount();
// BankAccount bankAccount = new BankAccount(0);
// badBankAccount.balance = 100;
// System.Console.WriteLine(bankAccount.getBalance());
// using TestConsoleApp.src.OopPrinciples.Abstraction;
// EmailService emailService = new EmailService();
// emailService.SendEmail();
// using TestConsoleApp.src.OopPrinciples.Polymorphism;
// List<Vehicle> vehicles = new List<Vehicle>();
// vehicles.Add(new Car{Brand = "Toyota",Model = "Camry",Year = 2028,numberOfDoors = 4,numberOfWheels = 4});
// vehicles.Add(new Bike{Brand = "Toyota",Model = "Camry",Year = 2016,numberOfDoors = 4,numberOfWheels = 4});
// Car c = new Car{Brand = "Toyota",Model = "Camry",Year = 2028,numberOfDoors = 4,numberOfWheels = 4};
// c.start();
// foreach(var vehicle in vehicles){
//    vehicle.start();
// }
// using TestConsoleApp.src.OopPrinciples.Coupling;
// Order order = new Order(new SMSSender());
// order.placeOrder();
// using TestConsoleApp.src.OopPrinciples.Composition;
// Car c = new Car();
// c.StartCar();
// using TestConsoleApp.src.SOLID.S;
// User user = new User();
// user.Email = "AmirDhahri1@gmail.com";
// UserService userService = new UserService();
// userService.Register(user);

using TestConsoleApp.src.SOLID.L;
var rec = new Rectangle();
rec.width = 10;
rec.height = 5;
System.Console.WriteLine("Expect area to be 50");
System.Console.WriteLine("Actual area = " + rec.Area);