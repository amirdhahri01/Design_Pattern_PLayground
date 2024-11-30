using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.DesignPatterns.Behavioral{
    public class History
    {
       private List<EditorState> _states = new List<EditorState>();
       private Editor _editor;

       private History(Editor _editor){
        this._editor = _editor;
       }

       public void Backup(){
        _states.add(_editor.CreateState())
       }

       public void Undo(){
          if(_states.Count == 0){
            return ;
          }
          EditorState prevState =  _states.Last();
          _states.Remove(prevState);
          _editor.Restore(prevState);
       }

       public void ShowHistory(){
            System.Console.WriteLine("\nHistory: Here is the list of mementos");
            foreach(var state in _states){
                System.Console.WriteLine(state.GetName());
            }
       }
    }
}
