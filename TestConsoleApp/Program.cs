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
// var rec = new Square();
// rec.SideLength = 10;
//rec.height = 5;
// System.Console.WriteLine("Expect area to be 100");
// System.Console.WriteLine("Actual area = " + rec.Area);
// Shape rectangle = new Rectangle{width=5 , height=10};
// System.Console.WriteLine($"Area of the rectangle {rectangle.Area}");
// Shape square = new Square{SideLength = 6};
// System.Console.WriteLine($"Area of the square {square.Area}");
// using TestConsoleApp.src.SOLID.I;
// var circle = new Circle();
// circle.Radius = 10;
// System.Console.WriteLine(circle.Area());
// var sphere = new Sphere();
// sphere.Radius = 10;
// System.Console.WriteLine(sphere.Area());
// System.Console.WriteLine(sphere.Volume());
//  using TestConsoleApp.src.SOLID.D;
//  var electricEngine = new ElectricEngine();
//  var engine = new Engine();
//  var car1 = new Car(electricEngine);
//  var car2 = new Car(engine);
//  car1.StartCar();
//  car2.StartCar();
// using TestConsoleApp.src.DesignPatterns.Behavioral.Memento;
// var editor = new Editor();
// var history = new History(editor);
// history.Backup();
// editor.Title = "test";
// history.Backup();
// editor.Content = "Hello there, my name is Amir Dhahri";
// history.Backup();
// editor.Title = "The life of a dev : my mementos";
// System.Console.WriteLine("Title : " + editor.Title);
// System.Console.WriteLine("Content : " + editor.Content);
// history.Undo();
// System.Console.WriteLine("Title : " + editor.Title);
// System.Console.WriteLine("Content : " + editor.Content);
// System.Console.WriteLine("|||||||||||||||||-||||||||||||||||||");
// history.ShowHistory();
// var doc = new Document();
// doc.State = DocumentStates.Moderation;
// doc.CurrentUserRole = UserRoles.Admin;
// System.Console.WriteLine(doc.State);
// doc.Publish();
// System.Console.WriteLine(doc.State);
// using TestConsoleApp.src.DesignPatterns.Behavioral.State.GoodSolution;
// Document doc = new Document(UserRoles.Editor);
// System.Console.WriteLine(doc._state);    
// doc.Publish();
// System.Console.WriteLine(doc._state);    
// doc.Publish();
// System.Console.WriteLine(doc._state);    
// Document doc = new Document(UserRoles.Admin);
// System.Console.WriteLine(doc.State);    
//  using TestConsoleApp.src.DesignPatterns.Behavioral.Strategy.GoodExample;
// VideoStorage vs = new VideoStorage(new CompressorMOV() , new OverlayBlur());
// vs.Store("myVideo");
/*using TestConsoleApp.src.DesignPatterns.Behavioral.Iterator;

ShoppingList shoppingList = new ShoppingList();

shoppingList.Add("Milk");
shoppingList.Add("Bread");
shoppingList.Add("Steak");
int count = shoppingList.GetList().Count;
for(int i = 0 ;i < count ; i++){
    var item = shoppingList.GetList()[i];
    System.Console.WriteLine(item);
}*/
// char c = 'c';
// Console.WriteLine(c);

// class Program{
//     public static void Main(string[] args){
//        string userName = "Amir Dhahri";
//        string phoneNumber = "94981522";
//        string str = string.Format("Name : {0}\nPhoneNumber : {1}", userName , phoneNumber);
//         Console.WriteLine(str);
//     }
// }
