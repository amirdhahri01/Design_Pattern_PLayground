using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.DesignPatterns.Behavioral.State.GoodSolution{
    public class ModerationState : State
    {
       private Document _document;

       public ModerationState(Document _document){
         this._document = _document;
       }
       public void Publish(){
         if(_document.CurrentUserRole == UserRoles.Admin){
            _document._state = new PublishedState(_document);
         }
       }
    }
}
