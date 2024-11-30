using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.DesignPatterns.Behavioral.State.GoodSolution{
    public class PublishedState : State
    {
       private Document _document;

       public PublishedState(Document _document){
         this._document = _document;
       }
       public void Publish(){
            
       }
    }
}
