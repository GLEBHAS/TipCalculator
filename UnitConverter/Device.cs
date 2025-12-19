    namespace TipCalculator
    {
      public class Device 
      {
        public Calculate calculate = new Calculate();
        public double Percentage;
        public double tipAmount;
        public double balance;
        public void Start()
        {
          Console.WriteLine("========== КАЛЬКУЛЯТОР ЧАЕВЫХ ==========");

          Console.Write($"Введите сумму заказа: ");

          balance = double.Parse(Console.ReadLine());

          Console.WriteLine($"Выбирите процент чаевых:\n 1. 10% \n 2. 15% \n 3. 20% \n 4. Свой вариант");

          Console.Write("Ваш выбор: ");

          int select = int.Parse(Console.ReadLine());

          switch (select)
          {
            case 1:
              tipAmount = calculate.TipCalculate(balance, 10);
              Percentage = 10;
              break;

            case 2:
              tipAmount = calculate.TipCalculate(balance, 15);
              Percentage = 15;
              break;

            case 3:
              tipAmount = calculate.TipCalculate(balance, 20);
              Percentage = 20;
              break;

            case 4:
              Percentage = double.Parse(Console.ReadLine());
              tipAmount = calculate.TipCalculate(balance, Percentage);
              break;

            default:
              Console.WriteLine("Неизвестная ошибка");
              return;
          }
        }

      public void PrintResult()
      {
        Console.WriteLine("========== РЕЗУЛЬТАТ ==========");

        Console.WriteLine($"Сумма заказа: {balance}");

        Console.WriteLine($"Чаевые ({Percentage}): {tipAmount} ₽");

        Console.WriteLine($"Итого к оплате: {tipAmount + balance} ₽");

        Console.WriteLine();
      }
    }
    }