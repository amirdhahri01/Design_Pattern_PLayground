// using TestConsoleApp.src.OopPrinciples.Encapsulation;
// BadBankAccount badBankAccount = new BadBankAccount();
// BankAccount bankAccount = new BankAccount(0);
// badBankAccount.balance = 100;
// System.Console.WriteLine(bankAccount.getBalance());
// using TestConsoleApp.src.OopPrinciples.Abstraction;
// EmailService emailService = new EmailService();
// emailService.SendEmail();

using TestConsoleApp.src.OopPrinciples.Inheritance;

List<Vehicle> vehicles = new List<Vehicle>();
vehicles.Add(new Car{Brand = "Toyota",Model = "Camry",Year = 2028,numberOfDoors = 4,numberOfWheels = 4});
vehicles.Add(new Bike{Brand = "Toyota",Model = "Camry",Year = 2016,numberOfDoors = 4,numberOfWheels = 4});
foreach(var vehicle in vehicles){
   vehicle.start();
}