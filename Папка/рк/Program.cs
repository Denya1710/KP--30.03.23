Console.Clear();
Console.WriteLine("Запуск консоли...");
Console.Write("Кто использует программу? ввод: ");
    string name =  Console.ReadLine();
     Console.WriteLine($"------ Привет  {name} ------");
Console.WriteLine($"");
Console.Write("Введите числа: ");
int numberN = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberN){
    
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);
Console.WriteLine("the end");
