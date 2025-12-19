namespace TipCalculator
{
  public class Program
  {
    public static void Main(string[] args)
    {
        Device device = new Device();
        device.Start();
        device.PrintResult();
    }
  }
}