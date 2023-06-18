
using System;
class main {
  static void Main(string[]args) {
     Console.Write("Enter your Marks: ");
    int marks = Convert.ToInt32(Console.ReadLine());
     
     if(marks>=90 && marks<=100){
         Console.Write("Topper");
     }
     else if(marks>=50 && marks<=90){
         Console.Write("pass");
     }
     else{
         Console.Write("fail");
     }
  }
}
/* Output
Enter your Marks: 95
Topper
*/
