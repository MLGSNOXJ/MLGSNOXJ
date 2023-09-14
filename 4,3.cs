using System;
class HelloWorld {
  static void Main() {
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int x = Convert.ToInt32(Console.ReadLine());
    for (int i = a; i <= b; i++){
        if(i % 10 == x){
            Console.Write(i + " ");
        }
    }
  }
}
