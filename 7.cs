using System;

class Program {
  static void Main() {
    Console.WriteLine("Наминал купюры = ");
    double a = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("Количество купюр = ");
    double b = Convert.ToDouble(Console.ReadLine());
    
    double c = a * b;
    
    Console.WriteLine("Сумма Денег = " + c.ToString("F2"));
    
  }
}
