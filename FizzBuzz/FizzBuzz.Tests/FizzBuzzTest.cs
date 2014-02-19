using NUnit.Framework;
using FizzBuzz.Lib;

namespace FizzBuzz.Tests
{
  [TestFixture]
  public class FizzBuzzTest
  {
    [Test]
    public void should_write_Fizz()
    {
      var fb = new FizzBuzzClass(3);
      Assert.IsTrue(fb.Write() == "Fizz");
    }

    [Test]
    public void should_write_buzz()
    {
      var fb = new FizzBuzzClass(5);
      Assert.IsTrue(fb.Write() == "Buzz");
    }

    [Test]
    public void should_write_fizzbuzz()
    {
      var fb = new FizzBuzzClass(15);
      Assert.IsTrue(fb.Write() == "FizzBuzz");
    }

    [Test]
    public void should_write_number()
    {
      var fb = new FizzBuzzClass(1);
      Assert.IsTrue(fb.Write() == fb.Counter.ToString());
    }

    [Test]
    public void should_increment()
    {
      var fb = new FizzBuzzClass();
      fb.Increment();
      Assert.IsTrue(fb.Counter == 1);
    }
  }
}
