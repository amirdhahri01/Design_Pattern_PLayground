using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.OopPrinciples.Abstraction{
    public class EmailService
    {
        public void ASendEmail(){
            Connect();
            Authenticate();
            System.Console.WriteLine("Sending email...");
            Disconnect();
        }
        private void Connect(){
            System.Console.WriteLine("Connecting to email server...");
        }
        private void Authenticate(){
            System.Console.WriteLine("Authenticating...");
        }
        private void Disconnect(){
            System.Console.WriteLine("Disconnecting from email server...");
        }
        
    }
}
