namespace TipCalculator
{
  public class Calculate
  {
    public double TipCalculate(double balance, double tipPercentage)
    {
      return (balance * tipPercentage) / 100;
    }
  }
}
