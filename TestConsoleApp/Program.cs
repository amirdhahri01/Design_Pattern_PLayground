
using TestConsoleApp.src.OopPrinciples.Encapsulation;

BadBankAccount badBankAccount = new BadBankAccount();
BankAccount bankAccount = new BankAccount(0);
badBankAccount.balance = 100;
System.Console.WriteLine(bankAccount.getBalance());