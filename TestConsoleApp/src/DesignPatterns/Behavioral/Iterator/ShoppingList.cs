using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.DesignPatterns.Behavioral.Iterator{
    public class ShoppingList
    {
       private List<string> _list = new List<string>();
       public void Add(string itemName){
          _list.Add(itemName);
       }
       public string Pop(){
          var last = _list.Last();
          _list.Remove(last);
          return last;
       }

       public List<string> GetList(){
          return _list;
       }

    }
}
