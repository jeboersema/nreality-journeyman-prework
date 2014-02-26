using NUnit.Framework;
using DataStructures.Lib;

namespace DataStructures.Tests
{
  [TestFixture]
  public class QueueTest
  {
    private Queue _queue;

    [TestFixtureSetUp]
    public void Init()
    {
      _queue = new Queue();
    }

    [TestFixtureTearDown]
    public void Dispose()
    {
      _queue = null;
    }

    [Test]
    public void should_add_item_to_queue()
    {
      var lengthBefore = _queue.Length;
      _queue.Add(new Item("Item 1"));
      Assert.IsTrue(_queue.Length > lengthBefore);
    }

    [Test]
    public void should_take_next_item_from_queue()
    {
      _queue.Add(new Item("Item x"));
      _queue.Add(new Item("Item y"));
      var o = _queue.Take();
      Assert.IsTrue(o != null && o.Name != "Item y");
    }

    [Test]
    public void should_remove_item_from_queue_when_taken()
    {
      _queue.Add(new Item("Item y"));
      var lengthBefore = _queue.Length;
      _queue.Take();
      Assert.IsTrue(_queue.Length < lengthBefore);
    }

    [Test]
    public void should_clear_all_items_from_queue()
    {
      _queue.Add(new Item("Item x"));
      _queue.Clear();
      Assert.IsTrue(_queue.Length == 0);
    }
  }
}
