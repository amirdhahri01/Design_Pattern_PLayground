using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.DesignPatterns.Behavioral.State{
    public class Document
    {
        public DocumentStates State{get;set;}
        public UserRoles CurrentUserRole{get;set;}
        
        public void Publish(){
            if(State == DocumentStates.Draft){
                State = DocumentStates.Moderation;
            }else if (State == DocumentStates.Moderation){
                if(CurrentUserRole == UserRoles.Admin){
                    State = DocumentStates.Published;
                }
            }
        } 
    }
}
