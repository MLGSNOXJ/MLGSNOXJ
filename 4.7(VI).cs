using System;

class HelloWorld {
  static void Main() {
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    int x = Convert.ToInt32(Console.ReadLine());

    for(int i = 0; i < n; i++){
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    for(int i = 0; i < n; i++){
        if(array[i] % 10 == x % 10){
          array[i] = 0;  
        }
    }

    for(int i = 0; i < n; i++){
        if(array[i] != 0){
          Console.Write(array[i] + " ");  
        }
    }
  }
}
