using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.DesignPatterns.Behavioral.Memento{
    //Memento
    public class EditorState
    {
       private readonly string _title;
       private readonly string _content;
    
       private readonly DateTime _stateCreatedAt;
       public EditorState(string _title , string _content){
            this._title = _title;
            this._content = _content;
            _stateCreatedAt = DateTime.Now;
       } 

       public string getTitle(){
            return _title;
       }
       public string getContent(){
            return _content;
       }

       public DateTime getDate(){
            return _stateCreatedAt;
       }

       public string GetName(){
         return $"{_stateCreatedAt}/{_title}";
       }
    }
}
