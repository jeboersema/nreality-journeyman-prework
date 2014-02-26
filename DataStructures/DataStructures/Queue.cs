using System;
using System.Linq;

namespace DataStructures.Lib
{
    public class Queue
    {
      private Item[] _items;
      private float _growthPercentage;
      private int _size;
      private int _capacity;
      
      public int Length {
        get { return _items.Length; }
      }

      public Queue(float growthPercentage = 10)
      {
        _size = _capacity = 4;
        _growthPercentage = growthPercentage;
        _items = new Item[_size];
      }

      public void Add(Item item)
      {
        if (_size == _capacity)
        {
          _capacity += (int)Math.Ceiling(_capacity * _growthPercentage / 100);
          Array.Resize(ref _items, _capacity);
        }
        _items[_size] = item;
        _size++;
      }

      public Item Take()
      {
        if (_size == 0) throw new Exception("Queue is empty");
        var result = _items.First();
        var index = 0;
        foreach (var item in _items.Skip(1))
          _items[index++] = item;
        _items[_size--] = null;
        return result;
      }

      public void Clear()
      {
        _items = new Item[] { };
      }
    }
}
