namespace FizzBuzz.Lib
{
    public class FizzBuzzClass
    {
      public int Counter { get; private set; }

      public FizzBuzzClass(int startCounter = 0)
      {
        Counter = startCounter;
      }

      public void Increment()
      {
        Counter++;
      }

      public string Write()
      {
        return IsFizzBuzz() ? "FizzBuzz" : IsBuzz() ? "Buzz" : IsFizz() ? "Fizz" : Counter.ToString();
      }

      public bool IsFizz()
      {
        return Counter%3 == 0;
      }

      public bool IsBuzz()
      {
        return Counter%5 == 0;
      }

      public bool IsFizzBuzz()
      {
        return IsFizz() & IsBuzz();
      }
    }
}
