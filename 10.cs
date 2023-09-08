using System;

class Program {
  static void Main() {
      
    Console.WriteLine("Как тебя зовут?");
    string a = Console.ReadLine();
    
    Console.WriteLine("Сколько тебе лет?");
    double b = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine(a + ", ты родился в " + (2009-b) + " году.");
    
  }
}
