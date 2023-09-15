using System;

class HelloWorld {
  static void Main() {
    int a = Convert.ToInt32(Console.ReadLine());
    int c = Convert.ToInt32(Console.ReadLine());
    
    int sqrtA = (int)Math.Sqrt(a);
    
    for (int i = 1; i <= sqrtA; i++){
      if(a % i == 0){
        if(i % c == 0){
          Console.Write(i + " ");
        }
        
        int otherFactor = a / i;
        
        if(otherFactor != i && otherFactor % c == 0){
          Console.Write(otherFactor + " ");
        }
      }
    }
  }
}
