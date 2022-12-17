using System;

namespace project2
{
  class Program
  {
    static void Main(string[] args)
    {
      int sum = 0 ;
      Console.WriteLine("Enter the first number:");
      int num1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter the Second number:");
      int num2 = int.Parse(Console.ReadLine());
      Console.WriteLine("The perfect numbers between {0} and {1} are" , num1 , num2);
     for(int i = num1 ; i <= num2 ; i++ ) {
       for(int k = 1 ; k < i ; k++ ){
        if( i % k == 0 ){
         sum += k ;
            
        } 
       }
       if(sum == i ){
          Console.WriteLine(i) ;
        }

        sum = 0 ;
      
      
      
    }
    }
  }
}