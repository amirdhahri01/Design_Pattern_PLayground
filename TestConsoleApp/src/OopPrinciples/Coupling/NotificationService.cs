using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.OopPrinciples.Coupling{
    public interface NotificationService
    {
        public void SendNotification(string message);
    }
}
