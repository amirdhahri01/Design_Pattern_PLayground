using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.DesignPatterns.Behavioral.State.GoodSolution{
    public class Document
    {
       public State _state{get;set;}
       public UserRoles CurrentUserRole{get;set;}

       public Document(UserRoles CurrentUserRole){
        this._state = new DraftState(this);
        this.CurrentUserRole = CurrentUserRole;
       }
       public void Publish(){
           _state.Publish(); 
       }
    }
}
