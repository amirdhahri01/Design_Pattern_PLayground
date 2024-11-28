using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.OopPrinciples.Coupling{
    public class SMSSender : NotificationService
    {
        public void SendNotification(string message){
            System.Console.WriteLine("Sending SMS : " + message);
        }
    }
}
