using System;
using System.Linq;

namespace DataStructures.Lib
{
    public class Queue
    {
      private Item[] _items;
      
      public int Length {
        get { return _items.Length; }
      }

      public Queue()
      {
        _items = new Item[] { };
      }

      public void Add(Item item)
      {
        Array.Resize(ref _items, _items.Length + 1);
        _items[_items.Length-1] = item;
      }

      public Item Take()
      {
        if (Length == 0) throw new Exception("Queue is empty");
        var result = _items[0];
        _items = _items.Skip(1).ToArray();
        return result;
      }

      public void Clear()
      {
        _items = new Item[] { };
      }
    }
}
