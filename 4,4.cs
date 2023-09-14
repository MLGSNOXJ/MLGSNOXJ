using System;
class HelloWorld {
  static void Main() {
    int a = Convert.ToInt32(Console.ReadLine());
    int c = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= a; i++){
        if(a % i == 0){
            if(i % c == 0){
                Console.Write(i + " ");
            }
        }
    }
  }
}
