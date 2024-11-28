using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.OopPrinciples.Coupling{
    public class Order 
    {
        private readonly NotificationService notificationService;
        
        public Order( NotificationService notificationService){
            this.notificationService = notificationService;
        }

        public void placeOrder(){
            //Place order logic
            notificationService.SendNotification("Order has placed successfully.");
        }
    }
}
